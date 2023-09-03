using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Rooms
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditRoomModel EditRoom { get; set; }
        public void OnGet(int id)
        {
            var room = dbContext.Rooms.Find(id);
            if (room != null)
            {
                EditRoom = new EditRoomModel
                {
                    Id = room.Id,
                    RoomType = room.RoomType,
                    Unvailable = room.Unvailable
                };
            }
        }


        public IActionResult OnPostEdit()
        {
            var existingRoom = dbContext.Rooms.Find(EditRoom.Id);
            if (existingRoom != null)
            {
                existingRoom.Id = EditRoom.Id;
                existingRoom.RoomType = EditRoom.RoomType;
                existingRoom.Unvailable = EditRoom.Unvailable;

                dbContext.SaveChanges();

                ViewData["Message"] = "Room Updated Successfully!";

                return RedirectToPage("/Rooms/List");
            }
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            var existingRoom = dbContext.Rooms.Find(EditRoom.Id);
            if(existingRoom != null)
            {
                dbContext.Rooms.Remove(existingRoom);
                dbContext.SaveChanges();
                return RedirectToPage("/Rooms/List");
            }
            return Page();
        }

    }
}

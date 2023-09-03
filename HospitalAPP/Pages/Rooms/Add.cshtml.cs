using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Rooms
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddRoomModel AddRoom { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var room = new Models.Room()
            {
                RoomType = AddRoom.RoomType,
                Unvailable = AddRoom.Unvailable
            };
            dbContext.Rooms.Add(room);
            dbContext.SaveChanges();
            ViewData["Message"] = "A Room has been Created Successfully!";
            return RedirectToPage("/Rooms/List");
        }
    }
}

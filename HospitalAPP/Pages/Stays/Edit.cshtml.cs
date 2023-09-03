using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Stays
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditStayModel EditStay { get; set; }
        public void OnGet(int id)
        {
            var stay = dbContext.Stays.Find(id);
            if (stay != null)
            {
                EditStay = new EditStayModel()
                {
                    Id = stay.Id,
                    PatientId = stay.PatientId,
                    RoomId = stay.RoomId,
                    StartTime = stay.StartTime,
                    EndTime = stay.EndTime
                };
            }
        }

        public IActionResult OnPostEdit()
        {
            var existingStay = dbContext.Stays.Find(EditStay.Id);
            if (existingStay != null)
            {
                existingStay.Id = EditStay.Id;
                existingStay.PatientId = EditStay.PatientId;
                existingStay.RoomId = EditStay.RoomId;
                existingStay.StartTime = EditStay.StartTime;
                existingStay.EndTime = EditStay.EndTime;

                dbContext.SaveChanges();

                ViewData["Message"] = "Stay Updated Successfully!";

                return RedirectToPage("/Stays/List");
            }
            return Page();
        }


    }
}

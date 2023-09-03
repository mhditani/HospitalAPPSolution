using HospitalAPP.Data;
using HospitalAPP.Models;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Stays
{
  public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddStayModel AddStay { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var stay = new Models.Stay()
            {
                PatientId = AddStay.PatientId,
                RoomId = AddStay.RoomId,
                StartTime = AddStay.StartTime,
                EndTime = AddStay.EndTime
            };
            dbContext.Stays.Add(stay);
            dbContext.SaveChanges();
            ViewData["Message"] = "A Stay has been Created Successfully!";
            return RedirectToPage("/Stays/List");
        }
    }
}

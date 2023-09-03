using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Nurses
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public AddNurseModel AddNurse { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            var nurse = new Models.Nurse()
            {
                Name = AddNurse.Name,
                Position = AddNurse.Position,
                Registered = AddNurse.Registered,
                SSN = AddNurse.SSN
            };
            dbContext.Nurses.Add(nurse);
            dbContext.SaveChanges();

            ViewData["Message"] = "A Nurse has been Created Successfully!";
            return RedirectToPage("/Nurses/List");
        }

    }
}

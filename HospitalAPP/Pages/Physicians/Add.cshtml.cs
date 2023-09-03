using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalAPP.Models;

namespace HospitalAPP.Pages.Physician
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public AddPhysicianModel  AddPhysician { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            
            var physician = new Models.Physician()
            {
                Name = AddPhysician.Name,
                SSN = AddPhysician.SSN,
                DateOfBirth = AddPhysician.DateOfBirth
            };
            dbContext.Physicians.Add(physician);
            dbContext.SaveChanges();

            ViewData["Message"] = "A Physician has been Created Successfully!";
            return RedirectToPage("/Physicians/List");
        }
    }
}

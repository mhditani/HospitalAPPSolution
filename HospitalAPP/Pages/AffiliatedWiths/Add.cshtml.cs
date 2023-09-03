using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.AffiliatedWiths
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public AddAffiliatedWithModel AddAffiliated { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var affiliation = new Models.AffiliatedWith()
            {
                PhysicianId = AddAffiliated.PhysicianId,
                DepartmentId = AddAffiliated.DepartmentId,
                PrimaryAffiliation = AddAffiliated.PrimaryAffiliation
            };
            dbContext.AffiliatedWiths.Add(affiliation);
            dbContext.SaveChanges();
            ViewData["Message"] = "An Affiliation has been Created Successfully!";
            return RedirectToPage("/AffiliatedWiths/List");

        }
        




    }   
}

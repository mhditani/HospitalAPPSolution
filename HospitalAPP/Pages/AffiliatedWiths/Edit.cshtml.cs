using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.AffiliatedWiths
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditAffiliatedWithModel EditAffiliation { get; set; }

        public void OnGet(int id)
        {
            var affiliation = dbContext.AffiliatedWiths.Find(id);
            if (affiliation != null)
            {
                EditAffiliation = new EditAffiliatedWithModel()
                {
                    Id = affiliation.Id,
                    PhysicianId = affiliation.PhysicianId,
                    DepartmentId = affiliation.DepartmentId,
                    PrimaryAffiliation = affiliation.PrimaryAffiliation
                };
            }
        }

        public IActionResult OnPostEdit()
        {
            if(EditAffiliation != null)
            {
                var existingAffiliation = dbContext.AffiliatedWiths.Find(EditAffiliation.Id);
                if (existingAffiliation != null)
                {
                    existingAffiliation.PhysicianId = EditAffiliation.PhysicianId;
                    existingAffiliation.DepartmentId = EditAffiliation.DepartmentId;
                    existingAffiliation.PrimaryAffiliation = EditAffiliation.PrimaryAffiliation;


                    dbContext.SaveChanges();

                    ViewData["Message"] = "Nurse Updated Successfully!";

                    return RedirectToPage("/AffiliatedWiths/List");
                }
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingAffiliation = dbContext.AffiliatedWiths.Find(EditAffiliation.Id);
            if (existingAffiliation != null)
            {
                dbContext.AffiliatedWiths.Remove(existingAffiliation);
                dbContext.SaveChanges();
                return RedirectToPage("/AffiliatedWiths/List");
            }
            return Page();
        }


    }
}

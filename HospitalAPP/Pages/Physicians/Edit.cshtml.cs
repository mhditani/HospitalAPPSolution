using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Physicians
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        [BindProperty]
        public EditPhysicianModel EditPhysician { get; set; }

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet(int id)
        {
            var physician = dbContext.Physicians.Find(id);
            if (physician != null)
            {
                EditPhysician = new EditPhysicianModel()
                {
                    Id = physician.Id,
                    Name = physician.Name,
                    SSN = physician.SSN,
                    DateOfBirth = physician.DateOfBirth

                };
            }
        }

        public IActionResult OnPostEdit()
        {
            if (EditPhysician != null)
            {
                var exisitngPhysician = dbContext.Physicians.Find(EditPhysician.Id);
                if (exisitngPhysician != null)
                {
                    exisitngPhysician.Name = EditPhysician.Name;
                    exisitngPhysician.SSN = EditPhysician.SSN;
                    exisitngPhysician.DateOfBirth = EditPhysician.DateOfBirth;

                    dbContext.SaveChanges();

                    ViewData["Message"] = "Physician Updated Successfully!";
                    return RedirectToPage("/Physicians/List");
                }
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingPhysician = dbContext.Physicians.Find(EditPhysician.Id);
            if (existingPhysician != null)
            {
                dbContext.Physicians.Remove(existingPhysician);
                dbContext.SaveChanges();
                return RedirectToPage("/Physicians/List");
            }
            return Page();
        }
    }
}

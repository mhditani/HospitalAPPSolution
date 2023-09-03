using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Medications
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditMedicationModel EditMed { get; set; }
        public void OnGet(int id)
        {
            var med = dbContext.Medications.Find(id);
            if (med != null)
            {
                EditMed = new EditMedicationModel()
                {
                    Id = med.Id,
                    Name = med.Name,
                    Brand = med.Brand,
                     Description = med.Description
                };
            }
        }


        public IActionResult OnPostEdit()
        {
            if (EditMed != null)
            {
                var existingMed = dbContext.Medications.Find(EditMed.Id);
                if (existingMed != null)
                {
                    existingMed.Name = EditMed.Name;
                    existingMed.Brand = EditMed.Brand;
                    existingMed.Description = EditMed.Description;

                    dbContext.SaveChanges();

                    ViewData["Message"] = "Medications Updated Successfully!";

                    return RedirectToPage("/Medications/List");
                }
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingMed = dbContext.Medications.Find(EditMed.Id);
            if (existingMed != null)
            {
                dbContext.Medications.Remove(existingMed);
                dbContext.SaveChanges();
                return RedirectToPage("/Medications/List");
            }
            return Page();
        }
    }
}

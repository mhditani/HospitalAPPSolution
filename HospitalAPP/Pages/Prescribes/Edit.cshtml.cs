using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Prescribes
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditPrescribeModel EditPrescribe { get; set; }
        public void OnGet(int id)
        {
            var pres = dbContext.Prescribess.Find(id);
            if (pres != null)
            {
                EditPrescribe = new EditPrescribeModel()
                {
                    Id = pres.Id,
                    PhysicianId = pres.PhysicianId,
                    PatientId = pres.PatientId,
                    MedicationId = pres.MedicationId,
                    MedicationTime = pres.MedicationTime,
                    AppointemntId = pres.AppointemntId,
                    Dose = pres.Dose
                };
            }
        }


        public IActionResult OnPostEdit()
        {
            var existingpres = dbContext.Prescribess.Find(EditPrescribe.Id);
            if (existingpres != null)
            {
                existingpres.PhysicianId = EditPrescribe.PhysicianId;
                existingpres.MedicationId = EditPrescribe.MedicationId;
                existingpres.PatientId = EditPrescribe.PatientId;
                existingpres.MedicationTime = EditPrescribe.MedicationTime;
                existingpres.AppointemntId = EditPrescribe.AppointemntId;
                existingpres.Dose = EditPrescribe.Dose;

                dbContext.SaveChanges();

                ViewData["Message"] = "Prescription Updated Successfully!";

                return RedirectToPage("/Prescribes/List");
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingPrescription = dbContext.Prescribess.Find(EditPrescribe.Id);

            if (existingPrescription != null)
            {
                dbContext.Prescribess.Remove(existingPrescription);
                dbContext.SaveChanges();
                return RedirectToPage("/Prescribes/List");
            }
            return Page();
        }
    }
}

using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Prescribes
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddPrescribeModel AddPrescribe { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var prescribe = new Models.Prescribes()
            {
                PhysicianId = AddPrescribe.PhysicianId,
                PatientId = AddPrescribe.PatientId,
                MedicationId = AddPrescribe.MedicationId,
                MedicationTime = AddPrescribe.MedicationTime,
                AppointemntId = AddPrescribe.AppointemntId,
                Dose = AddPrescribe.Dose
            };
            dbContext.Prescribess.Add(prescribe);
            dbContext.SaveChanges();
            ViewData["Message"] = "A Prescription has been Created Successfully!";
            return RedirectToPage("/Prescribes/List");

        }
    }
}

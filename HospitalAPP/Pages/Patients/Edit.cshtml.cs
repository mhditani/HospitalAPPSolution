using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Patients
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditPatientModel EditPatient { get; set; }
        public void OnGet(int id)
        {
            var patient = dbContext.Patients.Find(id);
            if (patient != null)
            {
                EditPatient = new EditPatientModel()
                {
                    Id = patient.Id,
                    Name = patient.Name,
                    Address = patient.Address,
                    PhoneNumber = patient.PhoneNumber,
                    InsuranceId = patient.InsuranceId,
                    PhysicianId = patient.PhysicianId
                };
            }
        }


        public IActionResult OnPostEdit()
        {
            if (EditPatient != null)
            {
                var existingPatient = dbContext.Patients.Find(EditPatient.Id);
                if (existingPatient != null)
                {
                    existingPatient.Name = EditPatient.Name;
                    existingPatient.Address = EditPatient.Address;
                    existingPatient.PhoneNumber = EditPatient.PhoneNumber;
                    existingPatient.InsuranceId = EditPatient.InsuranceId;
                    existingPatient.PhysicianId = EditPatient.PhysicianId;

                    dbContext.SaveChanges();

                    ViewData["Message"] = "Patient Updated Successfully!";
                    return RedirectToPage("/Pateints/List");
                    
                }
                
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingPatient = dbContext.Patients.Find(EditPatient.Id);
            if (existingPatient != null)
            {
                dbContext.Remove(existingPatient);
                dbContext.SaveChanges();
                return RedirectToPage("/Patients/List");
            }
            return Page();
        }
    }
}

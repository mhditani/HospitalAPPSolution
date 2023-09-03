using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Patients
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddPatientModel AddPatient { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            var patient = new Models.Patient()
            {
                Name = AddPatient.Name,
                Address = AddPatient.Address,
                PhoneNumber = AddPatient.PhoneNumber,
                InsuranceId = AddPatient.InsuranceId,
                PhysicianId = AddPatient.PhysicianId
            };
            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();

            ViewData["Message"] = "A Patient has been Created Successfully!";
            return RedirectToPage("/Patients/List");
        }
    }
}

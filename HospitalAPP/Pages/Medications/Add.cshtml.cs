using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Medications
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddMedicationModel AddMedication { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var med = new Models.Medication()
            {
                Name = AddMedication.Name,
                Brand = AddMedication.Brand,
                Description = AddMedication.Description
            };
            dbContext.Medications.Add(med);
            dbContext.SaveChanges();
            ViewData["Message"] = "A Medication has been Created Successfully!";
            return RedirectToPage("/Medications/List");

        }
    }
}

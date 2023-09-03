using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Patients
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Models.Patient> Patients { get; set; }
        public void OnGet()
        {
            Patients = dbContext.Patients.ToList();
        }
    }
}

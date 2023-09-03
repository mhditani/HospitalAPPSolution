using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Appointments
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public List<Models.Appointment> Appointments { get; set; }
        public void OnGet()
        {
            Appointments = dbContext.Appointments.ToList();
        }
    }
}

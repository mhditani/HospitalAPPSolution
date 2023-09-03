using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Medications
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public List<Models.Medication> Med { get; set; }
        public void OnGet()
        {
            Med = dbContext.Medications.ToList();
        }
    }
}

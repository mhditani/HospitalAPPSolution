using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Nurses
{
    public class ListModel : PageModel
    {

        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Models.Nurse> Nurses { get; set; }
        public void OnGet()
        {
            Nurses = dbContext.Nurses.ToList();
        }
    }
}

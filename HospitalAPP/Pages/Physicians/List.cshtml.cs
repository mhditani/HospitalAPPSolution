using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Physicians
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

          public   List< Models.Physician> Physicians { get; set; }
        public void OnGet()
        {
            Physicians = dbContext.Physicians.ToList();
        }
    }
}

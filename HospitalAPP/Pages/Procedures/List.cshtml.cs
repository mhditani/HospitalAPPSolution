using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Procedures
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public List<Models.Procedure> Procedure { get; set; }
        public void OnGet()
        {
            Procedure = dbContext.Procedures.ToList();
        }
    }
}

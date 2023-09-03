using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.AffiliatedWiths
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Models.AffiliatedWith> Affiliation { get; set; }
        public void OnGet()
        {
            Affiliation = dbContext.AffiliatedWiths.ToList();
        }
    }
}

using HospitalAPP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Departments
{
    public class ListModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public ListModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Models.Department> Department { get; set; }
        public void OnGet()
        {
            Department = dbContext.Departments.ToList();
        }
    }
}

using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Departments
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddDepartmentModel AddDepartment { get; set; }
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            var department = new Models.Department()
            {
                PhysicianId = AddDepartment.PhysicianId,
                Name = AddDepartment.Name
            };
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();
            ViewData["Message"] = "An Affiliation has been Created Successfully!";
            return RedirectToPage("/Departments/List");

        }
    }
}

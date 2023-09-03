using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Departments
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditDepartmentModel EditDepartment { get; set; }
        public void OnGet(int id)
        {
            var department = dbContext.Departments.Find(id);
            if (department != null)
            {
                EditDepartment = new EditDepartmentModel()
                {
                    Id = department.Id,
                    PhysicianId = department.PhysicianId,
                    Name = department.Name,
                };
            }
        }


        public IActionResult OnPostEdit()
        {
            if (EditDepartment != null)
            {
                var existingDepartment = dbContext.Departments.Find(EditDepartment.Id);
                if (existingDepartment != null)
                {
                    existingDepartment.Name = EditDepartment.Name;
                    existingDepartment.PhysicianId = EditDepartment.PhysicianId;




                    dbContext.SaveChanges();

                    ViewData["Message"] = "Department Updated Successfully!";
                    return RedirectToPage("/Departments/List");
                }
            }
            return Page();

        }

        public IActionResult OnPostDelete()
        {
            var existingDepartment = dbContext.Departments.Find(EditDepartment.Id);
            if(existingDepartment != null)
            {
                dbContext.Remove(existingDepartment);
                dbContext.SaveChanges();
                return RedirectToPage("/Departments/List");
            }
            return Page();
        }

    }
}

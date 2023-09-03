using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Procedures
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditProcedureModel EditProcedure { get; set; }
        public void OnGet(int id)
        {
            var proc = dbContext.Procedures.Find(id);
            if (proc != null)
            {
                EditProcedure = new EditProcedureModel()
                {
                    Id = proc.Id,
                    Code = proc.Code,
                    Name = proc.Name,
                    Cost = proc.Cost
                };
            }
        }

        public IActionResult OnPostEdit()
        {
            var existingprocedure = dbContext.Procedures.Find(EditProcedure.Id);
            if (existingprocedure != null)
            {
                existingprocedure.Id = EditProcedure.Id;
                existingprocedure.Code = EditProcedure.Code;
                existingprocedure.Name = EditProcedure.Name;
                existingprocedure.Cost = EditProcedure.Cost;

                dbContext.SaveChanges();

                ViewData["Message"] = "Procedure Updated Successfully!";

                return RedirectToPage("/Procedures/List");
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingproc = dbContext.Procedures.Find(EditProcedure.Id);

            if (existingproc != null)
            {
                dbContext.Procedures.Remove(existingproc);
                dbContext.SaveChanges();
                return RedirectToPage("/Procedures/List");
            }
            return Page();
        }

    }
}

using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Procedures
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public AddProcedureModel AddProcedure { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
           var procedure = new Models.Procedure()
           {
               Code = AddProcedure.Code,
               Name = AddProcedure.Name,
               Cost = AddProcedure.Cost
           };
            dbContext.Procedures.Add(procedure);
            dbContext.SaveChanges();
            ViewData["Message"] = "A Procedure has been Created Successfully!";
            return RedirectToPage("/Procedures/List");
        }
    }
}

using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Nurses
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditNurseModel EditNurse { get; set; }
        public void OnGet(int id)
        {
            var nurse = dbContext.Nurses.Find(id);
            if (nurse != null)
            {
                EditNurse = new EditNurseModel()
                {
                    Id = nurse.Id,
                    Name = nurse.Name,
                    Position = nurse.Position,
                    SSN = nurse.SSN,
                    Registered = nurse.Registered
                };
            }
        }

        public IActionResult OnPostEdit()
        {
            if (EditNurse != null)
            {
                var exisitngNurse = dbContext.Nurses.Find(EditNurse.Id);
                if (exisitngNurse != null)
                {
                    exisitngNurse.Name = EditNurse.Name;
                    exisitngNurse.Position = EditNurse.Position;
                    exisitngNurse.SSN = EditNurse.SSN;
                    exisitngNurse.Registered = EditNurse.Registered;


                    dbContext.SaveChanges();

                    ViewData["Message"] = "Nurse Updated Successfully!";
                    return RedirectToPage("/Nurses/List");
                }
                
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingNurse = dbContext.Nurses.Find(EditNurse.Id);
            if (existingNurse != null)
            {
                dbContext.Remove(existingNurse);
                dbContext.SaveChanges();
                return RedirectToPage("/Nurses/List");
            }
            return Page();
        }
    }
}

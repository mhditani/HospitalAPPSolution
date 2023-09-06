using HospitalAPP.Models;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System;
using HospitalAPP.Data;

namespace HospitalAPP.Pages.FeeCalculation
{
    public class FeeCalculationModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public FeeCalculationModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        
        public FeeModel FeeModel { get; set; } = new FeeModel(); // Initialize FeeModel

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

             FeeModel.CalculateTotalFee();

            return Page();
        }
    }
}

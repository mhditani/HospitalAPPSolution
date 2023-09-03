using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Appointments
{
    public class AddModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public AddModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public AddAppointmentModel AddAppointment { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var appointment = new Models.Appointment()
            {
                PatientId = AddAppointment.PatientId,
                NurseId = AddAppointment.NurseId,
                PhysicianId = AddAppointment.PhysicianId,
                StartDate = AddAppointment.StartDate,
                EndDate = AddAppointment.EndDate,
                ExaminationRoom = AddAppointment.ExaminationRoom
            };
            dbContext.Appointments.Add(appointment);
            dbContext.SaveChanges();
            ViewData["Message"] = "An Appointment has been Created Successfully!";
            return RedirectToPage("/Appointments/List");
        }
    }
}

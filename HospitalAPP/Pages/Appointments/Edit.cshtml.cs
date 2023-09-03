using HospitalAPP.Data;
using HospitalAPP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAPP.Pages.Appointments
{
    public class EditModel : PageModel
    {
        private readonly RazorPageDbContext dbContext;

        public EditModel(RazorPageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [BindProperty]
        public EditAppointmentModel EditAppointment { get; set; }
        public void OnGet(int id)
        {
            var app = dbContext.Appointments.Find(id);
            if (app != null) 
            {
                EditAppointment = new EditAppointmentModel()
                {
                    Id = app.Id,
                    PatientId = app.PatientId,
                    NurseId = app.NurseId,
                    PhysicianId = app.PhysicianId,
                    StartDate = app.StartDate,
                    EndDate = app.EndDate,
                    ExaminationRoom = app.ExaminationRoom
                };
            }
        }

        public IActionResult OnPostEdit()
        {
            var existingApp = dbContext.Appointments.Find(EditAppointment.Id);
            if (existingApp != null)
            {
                existingApp.PatientId = EditAppointment.PatientId;
                existingApp.NurseId = EditAppointment.NurseId;
                existingApp.PhysicianId = EditAppointment.PhysicianId;
                existingApp.StartDate = EditAppointment.StartDate;
                existingApp.EndDate = EditAppointment.EndDate;
                existingApp.ExaminationRoom = EditAppointment.ExaminationRoom;

                dbContext.SaveChanges();

                ViewData["Message"] = "Appointment Updated Successfully!";

                return RedirectToPage("/Appointments/List");
            }
            return Page();
        }


        public IActionResult OnPostDelete()
        {
            var existingApp = dbContext.Appointments.Find(EditAppointment.Id);
            if (existingApp != null)
            {
                dbContext.Appointments.Remove(existingApp);
                dbContext.SaveChanges();
                return RedirectToPage("/Appointments/List");
            }
            return Page();
        }
    }
}

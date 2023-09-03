using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditAppointmentModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int NurseId { get; set; }

        [Required]
        public int PhysicianId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int ExaminationRoom { get; set; }
    }
}

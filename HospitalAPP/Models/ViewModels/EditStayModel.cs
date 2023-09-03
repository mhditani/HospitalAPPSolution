using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditStayModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
    }
}

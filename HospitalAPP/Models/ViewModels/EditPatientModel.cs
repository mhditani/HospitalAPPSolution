using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditPatientModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int InsuranceId { get; set; }

        [Required]
        public int PhysicianId { get; set; }
    }
}

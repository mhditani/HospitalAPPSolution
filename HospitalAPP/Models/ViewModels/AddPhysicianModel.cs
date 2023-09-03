using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class AddPhysicianModel
    {
        [Required]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]


        public int SSN { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}

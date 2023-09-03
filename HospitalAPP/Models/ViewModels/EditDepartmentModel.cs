using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditDepartmentModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int PhysicianId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

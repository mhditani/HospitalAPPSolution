using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditAffiliatedWithModel
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public int PhysicianId { get; set; }

        [Required]
        public int DepartmentId { get; set; }



        public bool PrimaryAffiliation { get; set; }
    }
}

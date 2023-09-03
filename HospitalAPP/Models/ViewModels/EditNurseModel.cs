using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditNurseModel
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        
        public bool Registered { get; set; }

        [Required]
        public int SSN { get; set; }
    }
}

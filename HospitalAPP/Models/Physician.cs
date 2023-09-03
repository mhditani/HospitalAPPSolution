using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Physician
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

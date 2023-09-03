using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class AffiliatedWith
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

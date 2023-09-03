using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Prescribes
    {
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        public  int  PhysicianId { get; set; }
        
        [Required]
        public int PatientId { get; set; }
        
        [Required]
        public int MedicationId { get; set; }
        
        [Required]
        public DateTime MedicationTime { get; set; }
        
        [Required]
        public int AppointemntId { get; set; }
        [Required]
        public string Dose { get; set; }

    }
}

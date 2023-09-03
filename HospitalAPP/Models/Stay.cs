using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Stay
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

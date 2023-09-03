using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Room
    {
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string RoomType { get; set; }
        
        [Required]
        public bool Unvailable { get; set; }
    }
}

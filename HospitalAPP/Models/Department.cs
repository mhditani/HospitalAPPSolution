﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Department
    {
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int PhysicianId { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}

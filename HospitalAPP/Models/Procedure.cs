using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Procedure
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required.")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
        public decimal Cost { get; set; }
    }
}

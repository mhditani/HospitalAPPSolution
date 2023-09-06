using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models
{
    public class Fee
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public int PatientId { get; set; }
        [Required]

        public int MedicationId { get; set; }
        [Required]

        public int PrescribesId { get; set; }
        [Required]

        public int ProcedureId { get; set; }
        [Required]

        public int RoomId { get; set; }
        [Required]

        public int StayId { get; set; }



        [Required(ErrorMessage = "Cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
        public decimal RoomPricePerDay { get; set; }


        [Required(ErrorMessage = "Cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
        public decimal MedicinePrice { get; set; }

        [Required(ErrorMessage = "Cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
        public decimal ProcedurePrice { get; set; }

        [Required(ErrorMessage = "Cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
        public decimal TotalCost { get; set; }


        public string CalculateTotalFee()
        {
            TotalCost = RoomPricePerDay + MedicinePrice + ProcedurePrice;
            return TotalCost.ToString("0.00");
        }
    }
}

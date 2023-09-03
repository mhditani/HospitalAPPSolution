using System.ComponentModel.DataAnnotations;

namespace HospitalAPP.Models.ViewModels
{
    public class EditRoomModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string RoomType { get; set; }

        [Required]
        public bool Unvailable { get; set; }
    }
}

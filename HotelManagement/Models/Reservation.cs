using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Reservation
    {
        public string id { get; set; }
        public string guestName { get; set; }

        public DateTime checkInDate { get; set; }
        [Display(Name = "Check Out Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime checkOutDate { get; set;}
        public string email {  get; set; }

    }
}

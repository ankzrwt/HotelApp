namespace HotelManagement.Models
{
    public class Reservation
    {
        public string id { get; set; }
        public string guestName { get; set; }

        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set;}
        public string email {  get; set; }

    }
}

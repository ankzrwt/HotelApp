namespace HotelManagement.Models
{
    public interface IReservation
    {
        public Reservation add(Reservation reservation);
        public void remove(string id);
        public void update(Reservation reservation);
        public Reservation get(string id);

        public List<Reservation> getAll();

        public void printAll();
    }
}


namespace HotelManagement.Models
{
    public class ReservationRepository : IReservation
    {
        List<Reservation> reservations;
        public ReservationRepository()
        {
            this.reservations= new List<Reservation>();
        }

        public void printAll() { 
            foreach(var i in this.reservations)
            {
                Console.WriteLine(i.id);
            }
        }
        public Reservation add(Reservation reservation)
        {
           reservation.id = reservation.guestName+reservation.email;
           this.reservations.Add(reservation);
            return reservation;
        }

        public Reservation get(string id)
        {
            foreach(var i in reservations)
            {
                if(i.id==id)
                    return i;
            }
            return null;
           // return this.reservations.Find(res =>  res.id == id);
        }

        public List<Reservation> getAll()
        {
            return reservations;
        }

        public void remove(string id)
        {
            foreach(var i in reservations)
            {
                if(i.id==id)
                {
                    this.reservations.Remove(i);
                    return;

                }
            }
        }

        public void update(Reservation reservation)
        {
            int index=0;
            for(int i=0; i<reservations.Count;i++)
            {
                if (reservations[i].id==reservation.id)
                {
                    index = i;
                }
            }

            this.reservations[index] = reservation;
        }
    }
}

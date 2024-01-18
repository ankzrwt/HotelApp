
using System.Runtime.CompilerServices;

namespace HotelManagement.Models
{
    public class SqlRepository : IReservation
    {
        private AppDbContext context;

        public SqlRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Reservation add(Reservation reservation)
        {
            reservation.id = reservation.guestName + reservation.email;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return reservation;
        }

        public Reservation get(string id)
        {
            foreach(var reservation in context.Reservations)
            {
                if(reservation.id== id)
                {
                    return reservation;
                }
            }
            return null;
        }

        public List<Reservation> getAll()
        {
           return context.Reservations.ToList();
        }

        public void printAll()
        {
            return;
        }

        public void remove(string id)
        {
            foreach(var reservation in context.Reservations)
            {
                if(reservation.id== id) 
                {
                context.Reservations.Remove(reservation);
                context.SaveChanges();
                    return;
                }
            }
        }

        public void update(Reservation reservation)
        {
           
            var reser =  context.Reservations.Attach(reservation);
            reser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return;

            //foreach(var reserv in context.Reservations)
            //{
            //    if(reserv.id== reservation.id)
            //    {
            //        context.Reservations.Update(reservation);
            //        context.state
            //        context.SaveChanges();
            //        return;
            //    }
            //}
        }
    }
}

using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class ReservationController : Controller
    {
        private IReservation ireservation;
        public ReservationController(IReservation reservation)
        {
            this.ireservation = reservation;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult AddReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            ireservation.add(reservation);
            ireservation.printAll();
            return View("Index");
            
        }

        public IActionResult getAll()
        {
            
            ViewBag.reservation=ireservation.getAll();
            ireservation.printAll();
            return View();
        }

        public IActionResult DeleteReservation(string id) 
        {
            ireservation.remove(id);
            return RedirectToAction("getAll");
        }

        public IActionResult viewReservation(string id)
        {
            return View(ireservation.get(id));
        }

        public IActionResult UpdateReservation(Reservation reservation)
        {
            ireservation.update(reservation);
            return RedirectToAction("getAll");
        }
        //public IActionResult RemoveReservation() { }
    }
}

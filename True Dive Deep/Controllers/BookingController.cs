using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;



namespace True_Dive_Deep.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRepository _bookingRepository;

        public IActionResult Index()
        {
            var bookings = _bookingRepository.GetAll();
            return View(bookings);
        }

        public IActionResult Add(int? id)
        {
            ViewBag.Action = "add";

            var date = DateTime.Now;

            var booking = new Booking
            {
                StartTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0),
                EndTime = new DateTime(date.Year, date.Month, date.Day, date.Hour + 1, date.Minute, 0)
            };

            if (id != null)
            {
                booking.AccountId = id.Value;
            }

            return View(booking);
        }
    }
}

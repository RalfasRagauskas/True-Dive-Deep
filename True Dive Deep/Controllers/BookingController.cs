using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;



namespace True_Dive_Deep.Controllers
{
    public class BookingController : Controller
    {
        private static readonly List<Booking> Bookings = new List<Booking>();
        private static List<CartItem> CartItems = CartController.CartItems;

        public IActionResult Index()
        {
            return View(Bookings);
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (!CartItems.Any())
            {
                TempData["Error"] = "Din kurv er tom. Tilføj produkter før du booker.";
                return RedirectToAction("Index", "Cart");
            }

            // Viser en side hvor man kan vælge start/slutdato
            return View();
        }
        public IActionResult AddBooking(DateTime startDate, DateTime endDate)
        {
            if (!CartItems.Any())
            {
                TempData["Error"] = "Din kurv er tom.";
                return RedirectToAction("Index", "Cart");
            }

            if (endDate <= startDate)
            {
                TempData["Error"] = "Slutdato skal være efter startdato.";
                return View();
            }
            int days = (endDate - startDate).Days;
            decimal total = CartItems.Sum(c => c.PricePerDay * c.Quantity * days);

            // 🆕 Opret én samlet booking med unikt ID
            var booking = new Booking
            {
                BookingId = Guid.NewGuid(),   // ← her genereres et unikt ID
                Items = CartItems.ToList(),   // Kopi af kurv
                StartDate = startDate,
                EndDate = endDate,
                TotalPrice = total,
                CreatedAt = DateTime.Now
            };

            Bookings.Add(booking);

            // Tøm kurven efter booking
            CartItems.Clear();

            TempData["Success"] = "Din booking er gennemført! Booking ID: {booking.BookingId}";
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult DeleteBooking(Guid bookingId)
        {
            var booking = Bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                Bookings.Remove(booking);
                TempData["Success"] = "Booking blev slettet.";
            }
            else
            {
                TempData["Error"] = "Booking ikke fundet.";
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateBooking(Guid bookingId, DateTime newStartDate, DateTime newEndDate)
        {
            var booking = Bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null)
            {
                TempData["Error"] = "Booking ikke fundet.";
                return RedirectToAction("Index");
            }

            if (newEndDate <= newStartDate)
            {
                TempData["Error"] = "Slutdato skal være efter startdato.";
                return RedirectToAction("Index");
            }

            int days = (newEndDate - newStartDate).Days;
            booking.StartDate = newStartDate;
            booking.EndDate = newEndDate;
            booking.TotalPrice = booking.Items.Sum(c => c.PricePerDay * c.Quantity * days);

            TempData["Success"] = "Booking blev opdateret.";
            return RedirectToAction("Index");
        }
    }
}

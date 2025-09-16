using Microsoft.EntityFrameworkCore;
using True_Dive_Deep.Models;
using True_Dive_Deep.Data;
using True_Dive_Deep.Persistence;
namespace True_Dive_Deep.Persistence;

public class BookingRepository : IBookingRepository
{
   
    private readonly TrueDiveDeepContext _context;

    public BookingRepository(TrueDiveDeepContext context)
    {
        _context = context;
    }

    private static List<Booking> bookings = new List<Booking>
   {
       new Booking
       {
           BookingId = 1,
           Title = "Dykker Tur",
           StartTime = new DateTime(2025, 9, 16, 10, 30, 0),
           EndTime = new DateTime(2025, 9, 16, 11, 30, 0),
           AccountId = 1
       },
       new Booking
       {
           BookingId = 2,
           Title = "Møde - Team 3",
           StartTime = new DateTime(2025, 9, 15, 13, 30, 0),
           EndTime = new DateTime(2025, 9, 15, 15, 30, 0),
           AccountId = 2
       },
       new Booking
       {
           BookingId = 3,
           Title = "Ledermøde-Dykker",
           StartTime = new DateTime(2025, 9, 19, 8, 30, 0),
           EndTime = new DateTime(2025, 9, 19, 10, 30, 0),
           AccountId = 3
       }
   };

    public Booking? GetById(int id)
    {
        var booking = bookings.FirstOrDefault(x => x.BookingId == id);

        if (booking != null)
        {
            booking.Account = AccountRepository.GetById(booking.AccountId) ?? new Account();
        }
        return booking;
    }

    public List<Booking> GetAll()
    {
        if (bookings != null && bookings.Count > 0)
        {
            foreach (var booking in bookings)
            {
                booking.Account = AccountRepository.GetById(booking.AccountId) ?? new Account();
            }
        }

        return bookings ?? new List<Booking>();
    }

    public void Add(Booking booking)
    {
        if (booking == null) return;

        booking.BookingId = bookings.Any() ? bookings.Max(x => x.BookingId) + 1 : 1;

        bookings.Add(booking);
    }

    public void Update(Booking booking)
    {
        var bookingToUpdate = GetById(booking.BookingId);
        if (bookingToUpdate != null)
        {
            bookingToUpdate.Title = booking.Title;
            bookingToUpdate.StartTime = booking.StartTime;
            bookingToUpdate.EndTime = booking.EndTime;
            bookingToUpdate.AccountId = booking.AccountId;
        }
    }

    public void Delete(int id)
    {
        bookings.RemoveAll(x => x.BookingId == id);
    }
}


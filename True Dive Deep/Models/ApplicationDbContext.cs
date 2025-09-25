using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace True_Dive_Deep.Models
{
    public class ApplicationDbContext : IdentityDbContext<Account, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Booking> bookings { get; set; }
        //tilføje Dbsets her
    }
}
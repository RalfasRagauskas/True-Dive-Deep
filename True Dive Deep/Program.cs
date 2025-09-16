using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using True_Dive_Deep.Data;
using True_Dive_Deep.Models;
using True_Dive_Deep.Persistence;


namespace True_Dive_Deep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<TrueDiveDeepContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DiveDeepDatabase")); });
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");

            app.UseAuthorization();
            

            // builder.Services.AddScoped<BookingRepository, BookingRepository>();
            // builder.Services.AddScoped<AccountRepository, AccountRepository>();


            app.Run();
        }
    }
}

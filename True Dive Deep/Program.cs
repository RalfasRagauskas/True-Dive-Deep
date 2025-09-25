using Microsoft.AspNetCore.Identity;
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
            builder.Services.AddIdentity<Account, IdentityRole<int>>(options => { options.SignIn.RequireConfirmedAccount = false; })
                .AddEntityFrameworkStores<TrueDiveDeepContext>()
                .AddDefaultTokenProviders();
            builder.Services.AddRazorPages();


            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();


            // builder.Services.AddScoped<BookingRepository, BookingRepository>();
            // builder.Services.AddScoped<AccountRepository, AccountRepository>();


            app.Run();
        }
    }
}

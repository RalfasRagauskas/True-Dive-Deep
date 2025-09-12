using Microsoft.AspNetCore.Builder;
using True_Dive_Deep.Data;
using Microsoft.EntityFrameworkCore;


namespace True_Dive_Deep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<TrueDiveDeepContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DiveDeepDatabase")); });
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
            app.UseStaticFiles();




            app.Run();
        }
    }
}

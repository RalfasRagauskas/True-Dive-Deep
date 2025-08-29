using Microsoft.AspNetCore.Builder;

namespace True_Dive_Deep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
            app.UseStaticFiles();




            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using uniqilo.DataAcces;

namespace uniqilo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
            });
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();

           app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

             
             
            app.Run();
        }
    }
}

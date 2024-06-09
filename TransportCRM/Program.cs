using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TransportCRM.Areas.Identity.Data;
using TransportCRM.Data;
namespace TransportCRM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("TransportCRMContextConnection") ?? throw new InvalidOperationException("Connection string 'TransportCRMContextConnection' not found.");

            builder.Services.AddDbContext<TransportCRMContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<TransportCRMUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TransportCRMContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.MapRazorPages();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

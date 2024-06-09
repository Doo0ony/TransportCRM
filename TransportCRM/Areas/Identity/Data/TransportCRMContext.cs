using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TransportCRM.Areas.Identity.Data;
using TransportCRM.Models;

namespace TransportCRM.Data;

public class TransportCRMContext : IdentityDbContext<TransportCRMUser>
{
    public TransportCRMContext(DbContextOptions<TransportCRMContext> options)
        : base(options)
    {
    }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Transportation> Transportations { get; set; }
    public DbSet<Truck> Trucks { get; set; }
    public DbSet<ActivePage> ActivePages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}

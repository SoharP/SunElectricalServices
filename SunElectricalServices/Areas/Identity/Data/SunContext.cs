using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SunElectricalServices.Models;

namespace SunElectricalServices.Areas.Identity.Data;

public class SunContext : IdentityDbContext<IdentityUser>
{
    public SunContext(DbContextOptions<SunContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<SunElectricalServices.Models.Booking> Booking { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Customer> Customer { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Service> Service { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Staff> Staff { get; set; } = default!;
}

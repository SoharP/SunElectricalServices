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
        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2", Name = "Staff", NormalizedName = "STAFF" }
            );

        var harsher = new PasswordHasher<IdentityUser>();
        builder.Entity<IdentityUser>().HasData(

            new IdentityUser
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@sunelectrical.com",
                NormalizedEmail = "ADMIN@SUNELECTRICAL.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Admin@123")
            },
            new IdentityUser
            {
                Id = "2",
                UserName = "Sohar",
                NormalizedUserName = "SOHAR",
                Email = "ac116496@avcol.school.nz",
                NormalizedEmail = "AC116496@AVCOL.SCHOOL.NZ",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Employee@123")
            }

        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "1", UserId = "1" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "2" }
        );

    }

public DbSet<SunElectricalServices.Models.Booking> Booking { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Customer> Customer { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Service> Service { get; set; } = default!;

public DbSet<SunElectricalServices.Models.Staff> Staff { get; set; } = default!;
}

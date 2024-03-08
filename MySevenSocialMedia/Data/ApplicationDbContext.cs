using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySevenSocialMedia.Areas.Data;
using MySevenSocialMedia.Models.Domain;

namespace MySevenSocialMedia.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CalendarItem> CalendarItems { get; set; }
    }
}
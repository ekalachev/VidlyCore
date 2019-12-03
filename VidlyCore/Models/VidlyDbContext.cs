using Microsoft.EntityFrameworkCore;

namespace VidlyCore.Models
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
    }
}

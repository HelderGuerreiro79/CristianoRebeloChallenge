using Microsoft.EntityFrameworkCore;

namespace Microservice.UserPortal.DataLayer
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

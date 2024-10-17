using IdentityDataProtection.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityDataProtection.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // DbSet defined
        public DbSet<UserEntity> Users { get; set; } 
    }
}
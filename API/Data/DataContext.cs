using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Repair> Repair {get; set; }
        public DbSet<Photo>  Photo { get; set; }
    }
    
}
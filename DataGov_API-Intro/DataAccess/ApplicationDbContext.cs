using Microsoft.EntityFrameworkCore;
using Travel_API.Models;

namespace Travel_API.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }

        public DbSet<TravelInfo> TravelInfo { get; set; }
        public DbSet<Models.TravelInfo> TravelData { get; set; }
    }
}
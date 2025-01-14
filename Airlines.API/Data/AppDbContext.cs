using Airlines.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Airlines.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Airline> Airlines { get; set; }
    }
}

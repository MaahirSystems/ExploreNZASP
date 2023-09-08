using Microsoft.EntityFrameworkCore;
using ExploreNZASP.Models;

namespace ExploreNZASP.Data
{
    public class ExpressNZContext : DbContext
    {
        public ExpressNZContext(DbContextOptions<ExpressNZContext> options)
           : base(options)
        {
        }
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }
       

    }
}

using Microsoft.EntityFrameworkCore;
using ExploreNZASP.Models;
namespace ExploreNZASP.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ExpressNZContext(
                serviceProvider.GetRequiredService<DbContextOptions<ExpressNZContext>>()
            );

            // Check if the database has been seeded
            if (context.Users.Any())
            {
                return; // DB has been seeded
            }

            // Seed data for Users
            var users = new UserAccount[]
            {
            new UserAccount { Username="Alice", Email="alice@example.com", Password="Alice123" },
            new UserAccount { Username="Bob", Email="bob@example.com", Password="Bob123" },
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            // Seed data for Destinations
            var destinations = new Destination[]
            {
            new Destination { Name="Auckland", Description="The largest city in New Zealand." },
            new Destination { Name="Wellington", Description="The capital city of New Zealand." },
            };
            context.Destinations.AddRange(destinations);
            context.SaveChanges();

            // Seed data for Reviews
            var reviews = new Review[]
            {
            new Review { Comments="Great place!", Rating=5, User=users[0], Destination= destinations[0] },
            new Review { Comments="Loved Wellington!", Rating=4, User=users[1], Destination= destinations[1]},
            };
            context.Reviews.AddRange(reviews);
            context.SaveChanges();

            // Seed data for Bookings
            var bookings = new Booking[]
            {
            new Booking { BookingDate=DateTime.Now, Destination= destinations[0] ,User=users[0] },
            new Booking { BookingDate=DateTime.Now.AddDays(1), Destination= destinations[1], User=users[1] },
            };
            context.Bookings.AddRange(bookings);
            context.SaveChanges();
        }
    }
}

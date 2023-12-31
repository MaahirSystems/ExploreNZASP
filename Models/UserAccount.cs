﻿namespace ExploreNZASP.Models
{
    public class UserAccount
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } // Store hashed password for security
    public virtual ICollection<Booking> Bookings { get; set; }
}

}

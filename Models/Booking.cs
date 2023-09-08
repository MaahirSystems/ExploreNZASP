namespace ExploreNZASP.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DestinationId { get; set; }
        public DateTime BookingDate { get; set; }
        public virtual UserAccount User { get; set; }
        public virtual Destination Destination { get; set; }
    }


}

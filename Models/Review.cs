namespace ExploreNZASP.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DestinationId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; } // e.g., a value from 1-5
        public virtual UserAccount User { get; set; }
        public virtual Destination Destination { get; set; }
    }

}

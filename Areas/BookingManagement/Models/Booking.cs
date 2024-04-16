namespace GBCTravel105.Areas.BookingManagement.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string bookingtype { get; set; }
        public double price { get; set; }
        public DateOnly BookingDate { get; set; }
    }
}

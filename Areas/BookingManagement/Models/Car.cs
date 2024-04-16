using GBCTravel105.Data;
using Microsoft.EntityFrameworkCore;

namespace GBCTravel105.Areas.BookingManagement.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal DailyRate { get; set; }
        public bool IsAvailable { get; set; } = true;

    }


}

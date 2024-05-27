using System.Diagnostics;

namespace SunElectricalServices.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime Time { get; set; }
        public DateTime Day { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}

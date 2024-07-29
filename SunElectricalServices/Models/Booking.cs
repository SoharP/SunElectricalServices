using SunElectricalServices.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SunElectricalServices.Models
{
    public class Booking
    {
       [Key] public int BookingID { get; set; } //Unique identifier for each booking
        public int CustomerID { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; } // date of booking the service 
        public DateTime Day { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}
using SunElectricalServices.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SunElectricalServices.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [ForeignKey(CustomerID) public int CustomerID { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public DateTime Day { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
]
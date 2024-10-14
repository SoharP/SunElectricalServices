using SunElectricalServices.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SunElectricalServices.Models
{ 
    public enum Services
{
    [Display(Name = "Commercial")]
        Commercial,
    [Display(Name = "Residential")]
        Residential,
    [Display(Name = "Maintenance & Servicing")]
        Maintenance,
    [Display(Name = "EV Chargers")]
        EVChargers,
    [Display(Name = "Smart Home")]
        SmarttHome,
        [Display(Name = "Smart Home")]
        SmartHome
    }


public class Booking
{
    [Key]
    public int BookingID { get; set; } //Unique identifier for each booking

    public int CustomerID { get; set; }

    [DataType(DataType.Time)]
    public DateTime Time { get; set; } // time of booking the service 

    public string Services { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    [ForeignKey(nameof(CustomerID))]
    public Customer Customer { get; set; }
}
}
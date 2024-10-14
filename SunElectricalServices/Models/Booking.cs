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
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] // This attribute formats the date to be in a day/month/year form.
    public DateTime Date { get; set; }
    [ForeignKey(nameof(CustomerID))]

    public Customers Customer { get; set; }
}
}
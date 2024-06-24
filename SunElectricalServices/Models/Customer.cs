using Microsoft.AspNetCore.Mvc;
using SunElectricalServices.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunElectricalServices.Models
{
    public class Customer
    {
        [ForeignKey(BookingID) pubic int BookingID { get; set; }
        public int CustomerID { get; set; }
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        [DisplayName("Last Name")]
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID"), MaxLength(30)]
        public string Phone { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
    public ICollection<Booking> Bookings { get; set; }

    }
}

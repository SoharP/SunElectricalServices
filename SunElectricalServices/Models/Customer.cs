using Microsoft.AspNetCore.Mvc;
using SunElectricalServices.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunElectricalServices.Models
{
    public class Customers
    {

       [Key] public int CustomerID { get; set; } // This is the Customer's Unique Identifier

        [DisplayName("First Name")]
        // Will display as "First Name"
        public string First_Name { get; set; }
        [MaxLength(15)]

        [DisplayName("Last Name")]
        [DataType(DataType.Text)] // The type of data for this field is text.
        // Will display as "Last Name"
        public string Last_Name { get; set; }
        [MaxLength(20)]

        public string Address { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }
        [MaxLength(5)]
        public string Zip { get; set; }
       
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email Address")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
        // Validation for phone numbers (this doesnt allow any numbers to be written, needs a format such as (021)
        public string Phone { get; set; }
        public ICollection<Booking> Bookings { get; set; }

        internal static IQueryable<Customers> AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}

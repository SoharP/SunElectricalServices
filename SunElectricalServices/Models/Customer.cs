using System.ComponentModel.DataAnnotations;

namespace SunElectricalServices.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID"), MaxLength(30)]
        public string Phone { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}

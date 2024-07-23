using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SunElectricalServices.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID"), MaxLength(30)]
        public string Active { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SunElectricalServices.Models
{
    public enum Gender
    {
        [Display(Name = "Male")]
        Male,
        [Display(Name = "Female")]
        Female,
        [Display(Name = "Prefer not to say")]
        Prefernottosay
    }
    public class Staff
    {
      [Key] public int StaffID { get; set; } // This is the Staff's Unique Identifier
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }

        [DisplayName("Phone Number")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
        // Validation for phone numbers (this doesnt allow any numbers to be written, needs a format such as (021)
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter Email ID"), MaxLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public ICollection<Service> Services { get; set; }

    }
}

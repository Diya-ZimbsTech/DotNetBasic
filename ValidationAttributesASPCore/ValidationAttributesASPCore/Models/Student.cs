using System.ComponentModel.DataAnnotations;

namespace ValidationAttributesASPCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is must")]
        //[StringLength(10, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 10 characters")]
        //[MaxLength(10)]
        [MinLength(3,ErrorMessage ="Min length must be 3")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is must")]
        [RegularExpression("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Address")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is must")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 to 60")]
        public int? Age { get; set; }
        //[Required(ErrorMessage = "Confirm Password is must")]
        //[Compare("Password", ErrorMessage = "Password and Confirm Password must be same")]
        //[Display(Name ="Enter confirm password")]
        //public string ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "Password is must")]
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 to 15 characters and contain at least one uppercase letter, one lowercase letter, one numeric digit, and one special character.")]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Phone is must")]
        //[RegularExpression("^[0-9]{10}$", ErrorMessage = "Invalid Phone Number")]
        //public int Phone { get; set; }

        //[Required(ErrorMessage = "Website URL is must")]
        //[Url(ErrorMessage = "Invalid Website URL")]
        //public string WebsiteURL { get; set; }

    }
}

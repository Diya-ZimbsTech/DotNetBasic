using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Display(Name = "Enter Student Name")]
        [Required(ErrorMessage = "Please enter your name ")]
        //[StringLength(15,MinimumLength = 3 , ErrorMessage = "Name should be between 3 to 15 characters")]
        [MinLength(3 , ErrorMessage ="min lenth 3")]
        [MaxLength(15, ErrorMessage = "max lenth 15")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email ")]
        //[EmailAddress] //not preferres to use this attribute
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage ="Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your age ")]
        [Range(18, 60,ErrorMessage = "age is must between 18 to 60")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please enter your password ")]
        [RegularExpression("^(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Weak password. Use 8+ chars, 1 uppercase, 1 number, 1 special char")]
        public string Password { get; set; }

        [Required(ErrorMessage ="please enter confirmpassword")]
        [Compare("Password",ErrorMessage ="both password must match")]
        [Display(Name = "Enter Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your phone number ")]
        [RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$", ErrorMessage = "Invalid phone number")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Please enter your phone number ")]
        [Url(ErrorMessage ="invald url")]
        public string WebURL { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Product_Management_System.Models
{
    public class Membership
    {

        public int User_id { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        [Display(Name = "Enter UserName")]
        [StringLength(maximumLength: 8, MinimumLength = 3, ErrorMessage = "Username must have max length 8 and min length 3")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Emailid is Required")]
        [Display(Name = "Enter Emailid")]
        [EmailAddress(ErrorMessage = "Please enter valid email id !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "Password Must Contain Minimum 8 characters, at least one letter, one number and one special character")]
        public string Password { get; set; }
    }
}
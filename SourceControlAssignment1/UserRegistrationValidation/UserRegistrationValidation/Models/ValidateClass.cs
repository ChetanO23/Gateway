using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace UserRegistrationValidation.Models
{
    public class ValidateClass
    {
        [Required(ErrorMessage ="FirstName is Required")]
        [Display(Name = "Enter FirstName")]
        [StringLength(maximumLength: 8, MinimumLength = 3, ErrorMessage = "Firstname must have max length 8 and min length 3")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName is Required")]
        [Display(Name = "Enter LastName")]
        [StringLength(maximumLength: 8, MinimumLength = 3, ErrorMessage = "Lastname must have max length 8 and min length 3")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Display(Name ="Enter Your Age")]
        [Range(18,22,ErrorMessage ="Age must be between 18 and 22")]
        public int Age { get; set; }

        [Required(ErrorMessage ="College ID Number is Required")]
        [Display(Name ="Enter Your College ID Number")]
        //[RegularExpression("^([0-9]) {2} ([A-Za-z]) {2} ([0-9]) {3}$", ErrorMessage = "Invalid College ID Number")]
        [UserRegistrationValidation.CustomAttribute.IDNumber("17CP013")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage = "Emailid is Required")]
        [Display(Name ="Enter Emailid")]
        [EmailAddress(ErrorMessage ="Please enter valid email id !")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Mobile Number is Required")]
        [Display(Name = "Enter Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{5})[-. ]?([0-9]{5})$", ErrorMessage ="Not a valid Mobile number")]
        public string MobileNumber { get; set; }

        [Display(Name = "Enter Pan Card Number")]
        [RegularExpression("^([A-Za-z]) {5} ([0-9]) {4} ([A-Za-z]) {1}$", ErrorMessage ="Invalid PAN Number")]
        public string PanNumber { get; set; }

        [Required(ErrorMessage = "Please select Your Resume File")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.doc|.docx|.pdf)$", ErrorMessage ="Only Word Document and PDF file allowed")]
        public HttpPostedFileBase ResumeFile { get; set; }

        [Required(ErrorMessage ="Gender is Required")]
        [Display(Name ="Enter Your Gender")]
        public string Gender { get; set; }
        
        [Required]
        [Display(Name ="Enter Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$" ,ErrorMessage ="Password must contain atleast 8 characters and must have 1 alphabet and 1 number")]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name ="Terms & Conditions")]
        [Range(typeof(bool),"true","true",ErrorMessage ="Accept the Terms Of Services !")]
        public bool TermsandConditions { get; set; }



    }
}
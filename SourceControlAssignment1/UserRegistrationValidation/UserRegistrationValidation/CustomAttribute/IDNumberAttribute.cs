using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationValidation.CustomAttribute
{
    public class IDNumberAttribute : ValidationAttribute
    {
        private string iDnum;
        public IDNumberAttribute(string value)
        {
            iDnum = value;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                string idnum = (string)value;
                string Message = string.Empty;
                if(idnum != iDnum)
                {
                    Message = "College ID Number is Not Match";
                    return new ValidationResult(Message);
                }
            }
            return ValidationResult.Success;
        }
    }
}
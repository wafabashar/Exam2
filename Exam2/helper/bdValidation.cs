using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exam2.helper
{
    public class bdValidation:ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if(Convert.ToDateTime(value) > DateTime.Now)
            {
                return new ValidationResult("BirthDate should be less than today Date");
            }

            else
            {
                return ValidationResult.Success;
            }
            
        }

    }
}

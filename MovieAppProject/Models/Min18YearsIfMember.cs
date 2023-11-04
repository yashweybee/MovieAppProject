using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieAppProject.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.Monthly)
                return ValidationResult.Success;

            if (customer.DOB == null)
                return new ValidationResult("Dob Is required");

            var age = DateTime.Today.Year - customer.DOB.Year;
            return (age > 18) ? ValidationResult.Success : new ValidationResult("You are not 18+");
        }
    }
}
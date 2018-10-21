using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomVladiationDotNetCore.Models
{
    public class CustomValidateName : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Member member = (Member)validationContext.ObjectInstance;

            if (member.Name.Contains("sex") || member.Name.Contains("porn"))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return "This name contain sex or porn keyword.";
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            context.Attributes["data-val"] = "true";
            context.Attributes["data-val-custom-validate-product-name"] = GetErrorMessage();
        }
    }
}

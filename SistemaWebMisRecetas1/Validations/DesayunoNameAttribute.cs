using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebMisRecetas1.Validations
{
    public class DesayunoNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
          


            string categoria = Convert.ToString(value);


            if (categoria.ToUpper() != "DESAYUNO")

            {
                return new ValidationResult("La categoria debe ser escrita como desayuno");
            }
            return ValidationResult.Success;
        }

    }
}
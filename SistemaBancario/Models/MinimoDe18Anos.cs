using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class MinimoDe18Anos : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (Usuarios)validationContext.ObjectInstance;
            if (user.DataDeNascimento == null)
                return new ValidationResult("É necessária data de nascimento");

            var idade = DateTime.Today.Year - user.DataDeNascimento.Year;

            return (idade >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Usuario tem que ter ao menos 18 anos para abrir uma conta");
        }

    }
}
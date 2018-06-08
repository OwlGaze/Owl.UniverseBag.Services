using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Owl.UniverseBag.Application.DTO
{
    public static class FluentValidationExtensions
    {
        public static FluentValidation.Results.ValidationResult Validate<TObject,TValidator>(this TObject obj) where TValidator : AbstractValidator<TObject>
        {
            var validator = System.Activator.CreateInstance<TValidator>();
            return validator.Validate(obj);
        }
    }
}

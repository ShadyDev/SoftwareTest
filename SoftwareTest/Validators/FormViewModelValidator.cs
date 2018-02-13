using FluentValidation;
using SoftwareTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTest.Validators
{
    public class FormViewModelValidator : AbstractValidator<FormViewModel>
    {
        public FormViewModelValidator()
        {
            RuleFor(r => r.Width).NotEmpty().WithMessage("width field is required").GreaterThan(0).WithMessage("Must be bigger than 0");

            RuleFor(r => r.Height).NotEmpty().WithMessage("height field is required").GreaterThan(0).WithMessage("Must be bigger than 0");

            RuleFor(r => r.Depth).NotEmpty().WithMessage("depth field is required").GreaterThan(0).WithMessage("Must be bigger than 0");

            RuleFor(r => r.Weight).NotEmpty().WithMessage("weight field is required").GreaterThan(0).WithMessage("Must be bigger than 0");
        }
    }
}
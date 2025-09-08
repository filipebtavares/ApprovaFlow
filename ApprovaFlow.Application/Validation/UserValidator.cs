using ApprovaFlow.Core.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Validation
{
    public  class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(f => f.FullName)
                .NotEmpty().WithMessage("The full name not be must empty")
                .MaximumLength(100);

            RuleFor(s => s.Sector)
                .NotEmpty().WithMessage("The sector not be must invalid")
                .MaximumLength(50);

            RuleFor(r => r.Role)
                .NotEmpty().WithMessage("The role not be must empty")
                .MaximumLength(50);

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("The password not be must empty")
                .MinimumLength(8).WithMessage("The message not be must less then 8 characters. ")
                .MaximumLength(100).WithMessage("The password not be must greater than")
                .Matches("[A-Z]").WithMessage("The password must have capital letters")
                .Matches("[a-z]").WithMessage("The password must have lowercase letters")
                .Matches("[0-9]").WithMessage("the password must have numbers")
                .Matches("[^a-zA-Z0-9]").WithMessage("The password must have at least one special character");
        }
    }
}

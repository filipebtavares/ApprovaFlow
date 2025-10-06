using ApprovaFlow.Core.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Validation
{
    public  class PurchaseDecisionValidation : AbstractValidator<PurchaseDecision>
    {

        public PurchaseDecisionValidation()
        {
            RuleFor(b => b.RequestDecision)
                .NotEmpty().WithMessage("The decision not be must empty")
                .MaximumLength(800);
        }
    }
}

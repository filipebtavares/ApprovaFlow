using ApprovaFlow.Core.Entity;
using FluentValidation;


namespace ApprovaFlow.Application.Validation
{
    public  class PurchaseRequestValidation : AbstractValidator<PurchaseRequest>
    {

        public PurchaseRequestValidation()
        {
            RuleFor(dc => dc.RequestDescription)
                .NotEmpty().WithMessage("The descrption not be must empty")
                .MaximumLength(800);

            RuleFor(t => t.RequestTitle)
                .NotEmpty().WithMessage("The title not be must empty")
                .MaximumLength(60);

            RuleFor(i => i.UserId)
                .NotEmpty().WithMessage("The Id not be must empty")
                .LessThanOrEqualTo(0).WithMessage("try again with valid id");
        }
    }
}

using FluentValidation;
using GhabzeTo.Application.Core.DTOs.SPF;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Core.Validations
{
    public class SPFInputDtoValidator : AbstractValidator<SPFInputDto>
    {
        public SPFInputDtoValidator()
        {
            RuleFor(item => item.PageSize)
                .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                .GreaterThan(0).WithMessage(ValidationResourceKeys.LengthIsNotInRange)
                .LessThan(1000000).WithMessage(ValidationResourceKeys.LengthIsNotInRange);

            RuleFor(item => item.PageNumber)
                .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                .GreaterThan(0).WithMessage(ValidationResourceKeys.LengthIsNotInRange)
                .LessThan(1000000).WithMessage(ValidationResourceKeys.LengthIsNotInRange);
        }
    }
}

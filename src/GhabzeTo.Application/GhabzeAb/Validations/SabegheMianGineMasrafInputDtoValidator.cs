using FluentValidation;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Validations
{
    public class SabegheMianGineMasrafInputDtoValidator : AbstractValidator<SabegheMianGineMasrafInputDto>
    {
        public SabegheMianGineMasrafInputDtoValidator()
        {
            RuleFor(x => x.Dore)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                .NotEmpty().WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(x => x.SaleGhabl)
                            .Cascade(CascadeMode.StopOnFirstFailure)
                            .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                            .NotEmpty().WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(x => x.SaleJari)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                .NotEmpty().WithMessage(ValidationResourceKeys.NotNull);
        }
    }
}

using FluentValidation;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Validations
{
    public class GhabzeAbInputDtoValidator : AbstractValidator<GhabzeAbInputDto>
    {
        public GhabzeAbInputDtoValidator()
        {
            RuleFor(x => x.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage(ValidationResourceKeys.NotNull)
                .NotEmpty().WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(x => x.ShenaseGhabz)
                .Must(x => x > 0)
                .WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(x => x.ShenasePardakht)
               .Must(x => x > 0)
               .WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(x => x.SabegheMianGineMasrafs)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ValidationResourceKeys.NotNull)
                .Must(x => x.Count > 0)
                .WithMessage(ValidationResourceKeys.NotNull)
                .ForEach(_ => _.SetValidator(new SabegheMianGineMasrafInputDtoValidator()));
        }
    }
}

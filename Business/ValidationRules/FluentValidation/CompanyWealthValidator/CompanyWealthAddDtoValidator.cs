using Business.Constants;
using Entities.DTOs.CompanyWealthDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CompanyWealthValidator
{
    public class CompanyWealthAddDtoValidator : AbstractValidator<CompanyWealthAddDto>
    {
        public CompanyWealthAddDtoValidator()
        {
            RuleFor(b => b.CompanyName).MaximumLength(50).WithMessage($"Şirket Varlık İsmi {Messages.Max50Caracter}");
            RuleFor(b => b.CompanyName).NotEmpty().WithMessage($"Şirket Varlık Id {Messages.NotEmpty}");
            RuleFor(b => b.CompanyImage).NotEmpty().WithMessage($"Şirket Varlık İsim {Messages.NotEmpty}");
        }
    }
}
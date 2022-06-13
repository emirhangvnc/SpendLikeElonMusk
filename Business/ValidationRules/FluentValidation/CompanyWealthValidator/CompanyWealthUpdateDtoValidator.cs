using Business.Constants;
using Entities.DTOs.CompanyWealthDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CompanyWealthValidator
{
    public class CompanyWealthUpdateDtoValidator : AbstractValidator<CompanyWealthUpdateDto>
    {
        public CompanyWealthUpdateDtoValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"Şirket Varlık Id {Messages.NotEmpty}");
            RuleFor(b => b.CompanyName).MaximumLength(50).WithMessage($"Şirket Varlık İsim {Messages.Max50Caracter}");
            RuleFor(b => b.CompanyName).NotEmpty().WithMessage($"Şirket Varlık İsim {Messages.NotEmpty}");
        }
    }
}
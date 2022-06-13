using Business.Constants;
using Entities.DTOs.PersonalWealthDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.PersonalWealthValidator
{
    public class PersonalWealthUpdateDtoValidator : AbstractValidator<PersonalWealthUpdateDto>
    {
        public PersonalWealthUpdateDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage($"Favori Id {Messages.NotEmpty}");

            RuleFor(p => p.FirstName).MaximumLength(50).WithMessage($"İsim {Messages.Max50Caracter}");
            RuleFor(p => p.FirstName).NotEmpty().WithMessage($"İsim {Messages.NotEmpty}");

            RuleFor(p => p.LastName).MaximumLength(50).WithMessage($"Soy İsim {Messages.Max50Caracter}");
            RuleFor(p => p.LastName).NotEmpty().WithMessage($"Soy İsim {Messages.NotEmpty}");

            RuleFor(p => p.Fortune).NotEmpty().WithMessage($"Serveti {Messages.NotEmpty}");
        }
    }
}
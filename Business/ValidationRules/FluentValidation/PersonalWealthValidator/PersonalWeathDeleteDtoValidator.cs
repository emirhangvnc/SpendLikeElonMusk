using Business.Constants;
using Entities.DTOs.PersonalWealthDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.PersonalWealthValidator
{
    public class PersonalWealthDeleteDtoValidator : AbstractValidator<PersonalWealthDeleteDto>
    {
        public PersonalWealthDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage($"İsim {Messages.Max50Caracter}");
        }
    }
}
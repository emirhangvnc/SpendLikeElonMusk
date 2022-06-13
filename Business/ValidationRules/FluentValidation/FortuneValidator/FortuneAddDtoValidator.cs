using Business.Constants;
using Entities.DTOs.FortuneDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FortuneValidator
{
    public class FortuneAddDtoValidator : AbstractValidator<FortuneAddDto>
    {
        public FortuneAddDtoValidator()
        {
            RuleFor(f => f.FortuneId).NotEmpty().WithMessage($"Varlık {Messages.NotEmpty}");
        }
    }
}
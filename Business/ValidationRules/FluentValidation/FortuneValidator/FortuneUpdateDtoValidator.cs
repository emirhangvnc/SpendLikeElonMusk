using Business.Constants;
using Entities.DTOs.FortuneDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FortuneValidator
{
    public class FortuneUpdateDtoValidator : AbstractValidator<FortuneUpdateDto>
    {
        public FortuneUpdateDtoValidator()
        {
            RuleFor(f => f.Id).NotEmpty().WithMessage($"Favori Id {Messages.NotEmpty}");
            RuleFor(f => f.FortuneId).NotEmpty().WithMessage($"Varlık {Messages.NotEmpty}");
        }
    }
}
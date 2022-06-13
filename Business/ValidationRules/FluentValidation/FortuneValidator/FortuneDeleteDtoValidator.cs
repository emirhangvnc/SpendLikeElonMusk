using Business.Constants;
using Entities.DTOs.FortuneDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FortuneValidator
{
    public class FortuneDeleteDtoValidator : AbstractValidator<FortuneDeleteDto>
    {
        public FortuneDeleteDtoValidator()
        {
            RuleFor(f => f.Id).NotEmpty().WithMessage($"Varlık Id {Messages.NotEmpty}");
        }
    }
}
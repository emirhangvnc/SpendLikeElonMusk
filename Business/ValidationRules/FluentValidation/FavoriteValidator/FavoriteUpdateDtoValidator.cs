using Business.Constants;
using Entities.DTOs.FavoriteDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FavoriteValidator
{
    public class FavoriteUpdateDtoValidator : AbstractValidator<FavoriteUpdateDto>
    {
        public FavoriteUpdateDtoValidator()
        {
            RuleFor(f => f.Id).NotEmpty().WithMessage($"Favori Id {Messages.NotEmpty}");
            RuleFor(f => f.FortuneId).NotEmpty().WithMessage($"Varlık {Messages.NotEmpty}");
        }
    }
}
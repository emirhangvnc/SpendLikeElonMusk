using Business.Constants;
using Entities.DTOs.FavoriteDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FavoriteValidator
{
    public class FavoriteAddDtoValidator : AbstractValidator<FavoriteAddDto>
    {
        public FavoriteAddDtoValidator()
        {
            RuleFor(f => f.FortuneId).NotEmpty().WithMessage($"Varlık {Messages.NotEmpty}");
        }
    }
}
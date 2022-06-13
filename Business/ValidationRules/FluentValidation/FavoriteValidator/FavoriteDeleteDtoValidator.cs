using Business.Constants;
using Entities.DTOs.FavoriteDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.FavoriteValidator
{
    public class FavoriteDeleteDtoValidator : AbstractValidator<FavoriteDeleteDto>
    {
        public FavoriteDeleteDtoValidator()
        {
            RuleFor(f => f.Id).NotEmpty().WithMessage($"Favori Id {Messages.NotEmpty}");
        }
    }
}
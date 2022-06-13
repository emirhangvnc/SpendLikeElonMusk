using Business.Constants;
using Entities.DTOs.CategoryDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CategoryValidator
{
    public class CategoryDeleteDtoValidator : AbstractValidator<CategoryDeleteDto>
    {
        public CategoryDeleteDtoValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"Kategori Id {Messages.NotEmpty}");
        }
    }
}
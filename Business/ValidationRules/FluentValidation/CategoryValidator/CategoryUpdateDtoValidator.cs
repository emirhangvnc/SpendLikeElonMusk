using Business.Constants;
using Entities.DTOs.CategoryDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CategoryValidator
{
    public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"Kategori Id {Messages.NotEmpty}");
            RuleFor(b => b.CategoryName).MaximumLength(50).WithMessage($"Kategori İsmi{Messages.Max50Caracter}");
            RuleFor(b => b.CategoryName).NotEmpty().WithMessage($"Kategori İsim {Messages.NotEmpty}");
        }
    }
}
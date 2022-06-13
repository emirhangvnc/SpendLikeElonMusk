using Business.Constants;
using Entities.DTOs.CategoryDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CategoryValidator
{
    public class CategoryAddDtoValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(b => b.CategoryName).MaximumLength(50).WithMessage($"Kategori İsmi{Messages.Max50Caracter}");
            RuleFor(b => b.CategoryName).NotEmpty().WithMessage($"Kategori İsim {Messages.NotEmpty}");
            RuleFor(p => p.CategoryName).Must(IsValidName).WithMessage($"Kategori İsmi Metinsel İfade İçermelidir");
        }
        private bool IsValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}
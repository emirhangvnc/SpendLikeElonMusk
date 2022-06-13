using Business.Constants;
using Entities.DTOs.CategoryDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.CompanyWealthValidator
{
    public class CompanyWealthDeleteDtoValidator : AbstractValidator<CategoryDeleteDto>
    {
        public CompanyWealthDeleteDtoValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"Kategori Id {Messages.NotEmpty}");
        }
    }
}
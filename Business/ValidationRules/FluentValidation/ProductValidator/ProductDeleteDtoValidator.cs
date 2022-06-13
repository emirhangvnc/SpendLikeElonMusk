using Business.Constants;
using Entities.DTOs.ProductDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.ProductValidator
{
    public class ProductDeleteDtoValidator : AbstractValidator<ProductDeleteDto>
    {
        public ProductDeleteDtoValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage($"Ürün Id {Messages.NotEmpty}");
        }
    }
}
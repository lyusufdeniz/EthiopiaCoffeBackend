using EthiopiaCoffe.Repository.DTOs.Category;
using FluentValidation;

namespace EthiopiaCoffe.Infrastructure.Validations.Category
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDTO>
    {
        public CategoryAddValidator()
        {
            RuleFor(x => x.Name).Length(3, 30).WithMessage("{PropertyName} Length must between 3 and 15");
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("{PropertyName} must not be null");
            RuleFor(x => x.Description).Length(3, 80).WithMessage("{PropertyName} Length must between 3 and 50");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("{PropertyName} must not be null");


        }
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Category Name Cannot be empty");
            RuleFor(x => x.categoryDescription).NotEmpty().WithMessage("Category Description Cannot be empty");
            RuleFor(x => x.categoryName).MaximumLength(50).WithMessage("Category Name cannot be longer than 50 characters");
            RuleFor(x => x.categoryName).MinimumLength(2).WithMessage("Category Name cannot be shorter than 2 characters");

        }
    }
}

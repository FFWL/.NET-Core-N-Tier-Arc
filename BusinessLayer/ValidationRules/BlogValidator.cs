using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.blogTitle).NotEmpty().WithMessage("You cannot create new blog without title");
            RuleFor(x => x.blogContent).NotEmpty().WithMessage("You cannot create new blog without content");
            RuleFor(x => x.blogImage).NotEmpty().WithMessage("You cannot create new blog without image");
            RuleFor(x => x.blogTitle).MaximumLength(150).WithMessage("please enter content less than 150 characters");

        }
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.writerName).NotEmpty().WithMessage("Writer Name and Surname Cannot be empty");
            RuleFor(x=>x.writerMail).NotEmpty().WithMessage("Writer Mail Cannot be empty");
            RuleFor(x => x.writerPassword).NotEmpty().WithMessage("Password Cannot be empty");
            RuleFor(x => x.writerPassword).Matches(@"[A-Z]+").WithMessage("Password must contain at least one uppercase letter");
            RuleFor(x => x.writerName).MinimumLength(2).WithMessage("Writer Name and Surname must longer than 2 characters");
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.Business.Validations
{
    public  class QuestionValidator:AbstractValidator<Quest>
    {
        public QuestionValidator()
        {
          
            RuleFor(x=>x.Question).NotEmpty().WithMessage("Soru boş bırakılamaz");
            RuleFor(x => x.Question).MinimumLength(10).WithMessage("Soru en az 10 karakterden oluşmalıdır");
            RuleFor(x => x.Question).MaximumLength(300).WithMessage("Soru en fazla 200 karakterden oluşmalıdır");
            RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap boş bırakılamaz");
            RuleFor(x => x.Answer).MinimumLength(10).WithMessage("Cevap en az 20 karakterden oluşmalıdır");
            RuleFor(x => x.Answer).MaximumLength(300).WithMessage("Cevap en fazla 300 karakterden oluşmalıdır");

        }
    }
}

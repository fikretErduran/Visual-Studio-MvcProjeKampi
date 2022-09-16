using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
      public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Don't can' Name part not empty !!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("SurName kısmını bos gecemezsıniz!!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını bos gecemezsıniz!!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında  kısmını bos gecemezsıniz!!");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz!!");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen  20 karakterden fazla  giriş yapmayınız!!");
        }
    }
}

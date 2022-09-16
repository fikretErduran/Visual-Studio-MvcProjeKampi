﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class HeadingValidator:AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Heading Adını Boş Geçemezsiniz!!");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.HeadingName).MaximumLength(20).WithMessage("20 karakterden fazla giris yapmayınız");
        } 
    }
}

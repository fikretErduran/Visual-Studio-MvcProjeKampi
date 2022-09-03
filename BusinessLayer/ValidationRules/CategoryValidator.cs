using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory Adini Bos Gecemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Aciklamayi Bos Gecemezsiniz");
            RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Lutfen 25 karakterden fazla girmetiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lutfen en az 3 karakter giriniz");

        } 
    }
}

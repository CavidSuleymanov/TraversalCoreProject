using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Aciklama kismi bos kecilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lutfen gorsel seciniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lutfen en az 50 karakterlik aciklama kismi giriniz");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lutfen aciklamayi kisaltin..");


        }
    }
}

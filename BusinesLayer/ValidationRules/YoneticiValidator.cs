using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.ValidationRules
{
    public class YoneticiValidator: AbstractValidator<Yonetici>
    {
        public YoneticiValidator()
        {
            RuleFor(x => x.YoneticiAdi).NotEmpty().WithMessage("Yonetici ismi bos gecilemez");
            RuleFor(x => x.YoneticiSoyadi).NotEmpty().WithMessage("Yonetici soyismi bos gecilemez");
            RuleFor(x => x.YoneticiMail).NotEmpty().WithMessage("Yonetici mail bos gecilemez");
            RuleFor(x => x.YoneticiSifre).NotEmpty().WithMessage("Yonetici sifre bos gecilemez");

            RuleFor(x => x.YoneticiAdi).MinimumLength(3).WithMessage("Yonetici ismi en az 3 karakter olmali");
            RuleFor(x => x.YoneticiAdi).MaximumLength(30).WithMessage("Yonetici ismi en az 30 karakter olmali");



        }

    }
}

using FluentValidation;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Business.ValidationRules.FluentValidation
{
    public class OgrenciValidator:AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(p => p.OgrenciAd).NotEmpty().WithMessage("İsim Alanı Boş Olamaz.");
            RuleFor(p => p.OgrenciSoyad).NotEmpty();
            RuleFor(p => p.OgrenciNumara).GreaterThan(0);
            RuleFor(p => p.OgrenciAlan).NotEmpty();
        }
    }
}

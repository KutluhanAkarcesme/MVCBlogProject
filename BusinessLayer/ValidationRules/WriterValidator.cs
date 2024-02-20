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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Bırakılamaz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Bırakılamaz");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage("Hakkımda Kısmı Boş Bırakılamaz");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Yazar Soyadı En Az 2 Karakter Olmalıdır");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Yazar  Soyadı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan Kısmını Boş Bırakamazsınız");
        }
    }
}

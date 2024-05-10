using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {

        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Proje tamamlanma oranı boş geçilemez");
        }

    }
}

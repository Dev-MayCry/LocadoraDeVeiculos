using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos {
    public class ValidadorConfiguracaoPreco: AbstractValidator<ConfiguracaoDePreco>, IValidadorConfiguradorPreco {
        public ValidadorConfiguracaoPreco() {
            RuleFor(x => x.PrecoAlcool).NotEmpty().NotNull();
            RuleFor(x => x.PrecoDiesel).NotEmpty().NotNull();
            RuleFor(x => x.PrecoGas).NotEmpty().NotNull();
            RuleFor(x => x.PrecoGasolina).NotEmpty().NotNull();
        }

    }
}

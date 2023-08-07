using FluentValidation;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxaServico {
    public class ValidadorTaxaServico : AbstractValidator<TaxaServico>, IValidadorTaxaServico{
        
        public ValidadorTaxaServico() {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
        }
    }
}

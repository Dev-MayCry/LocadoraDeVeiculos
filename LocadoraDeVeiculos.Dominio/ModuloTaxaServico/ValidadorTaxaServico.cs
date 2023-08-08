using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxaServico {
    public class ValidadorTaxaServico : AbstractValidator<TaxaServico>, IValidadorTaxaServico{
        
        public ValidadorTaxaServico() {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(x => x.Preco).NotEmpty().NotNull();
            RuleFor(x => x.TipoPlano).NotEmpty().NotNull();

        }
    }
}

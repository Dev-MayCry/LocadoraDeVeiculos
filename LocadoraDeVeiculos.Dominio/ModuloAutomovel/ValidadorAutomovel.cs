using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel {
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel {
        public ValidadorAutomovel() {
            RuleFor(x => x.Placa).NotEmpty().NotNull(); //Se precisar coloca o regex da placa aqui
        }
    }
}

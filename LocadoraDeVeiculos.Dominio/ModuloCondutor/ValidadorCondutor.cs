using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor {
    public class ValidadorCondutor : AbstractValidator<Condutor>, IValidadorCondutor {

        public ValidadorCondutor() {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(x => x.Email).NotEmpty().NotNull();
            RuleFor(x => x.Cpf).NotEmpty().NotNull();
            RuleFor(x => x.Cnh).NotEmpty().NotNull();
            RuleFor(x => x.Telefone).NotEmpty().NotNull();
            RuleFor(x => x.DataValidade).NotEmpty().NotNull();
            RuleFor(x => x.Cliente).NotEmpty().NotNull();
        }
    }
}

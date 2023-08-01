using FluentValidation;


namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario {
    public class ValidadorFuncionario : AbstractValidator<Funcionario>, IValidadorFuncionario {

        public ValidadorFuncionario() {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}

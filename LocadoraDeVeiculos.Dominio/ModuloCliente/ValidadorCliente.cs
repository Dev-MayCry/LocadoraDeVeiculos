using FluentValidation;
using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente
    {
        public ValidadorCliente()
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(x => x.Email).NotEmpty().NotNull().VerificadorDeEmails().WithMessage("O email deve estar em um formato válido.");
            RuleFor(x => x.Telefone).NotEmpty().NotNull();
            RuleFor(x => x.Cpf).NotEmpty().NotNull();
            RuleFor(x => x.Cnpj).NotEmpty().NotNull();
            RuleFor(x => x.Cidade).NotEmpty().NotNull();
            RuleFor(x => x.Bairro).NotEmpty().NotNull();
            RuleFor(x => x.Rua).NotEmpty().NotNull();
            RuleFor(x => x.NumeroDaCasa).NotEmpty().NotNull();
            RuleFor(x => x.Estado).NotEmpty().NotNull();
            RuleFor(x => x.TipoCliente).Must(x => x > 0);

        }
    }

}
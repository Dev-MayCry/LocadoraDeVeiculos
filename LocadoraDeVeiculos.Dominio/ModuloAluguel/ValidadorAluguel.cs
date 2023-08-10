using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel {
    public class ValidadorAluguel : AbstractValidator<Aluguel>, IValidadorAluguel {
        public ValidadorAluguel() {
            RuleFor(x => x.Cliente).NotEmpty().NotNull();
            RuleFor(x => x.Condutor).NotEmpty().NotNull();
            RuleFor(x => x.GrupoAutomovel).NotEmpty().NotNull();
            RuleFor(x => x.Automovel).NotEmpty().NotNull();
            RuleFor(x => x.PlanoCobranca).NotEmpty().NotNull();
            RuleFor(x => x.KmAutomovel).Must(x => x > 0);
            RuleFor(x => x.DataLocacao).NotNull().NotEmpty();
            RuleFor(x => x.DataDevolucaoPrevista).NotNull().NotEmpty();
            RuleFor(x => x.Cupom);
            RuleFor(x => x.TaxasSelecionadas);
            RuleFor(x => x.DataDevolucao);
            RuleFor(x => x.KmPercorrido);
            RuleFor(x => x.NivelTanque);
            RuleFor(x => x.ValorTotal);
        }
    }
}
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca {
    public class ValidadorPlanoCobranca : AbstractValidator<PlanoCobranca>, IValidadorPlanoCobranca {

        public ValidadorPlanoCobranca() {
            RuleFor(x => x.grupo).NotEmpty().NotNull().WithMessage("Selecione um grupo de automóveis!");
            RuleFor(x => x.PrecoDiaria).NotEmpty().NotNull();


            When(x => x.tipo == TipoPlanoEnum.PlanoDiario, () => {
                RuleFor(x => x.PrecoKm).NotEmpty().NotNull();

            });


            When(x => x.tipo == TipoPlanoEnum.PlanoControlador, () =>
            {
                RuleFor(x => x.PrecoKm).NotEmpty().NotNull();
                RuleFor(x => x.KmDisponiveis).NotEmpty().NotNull();

            });

            

            
        }
    
    }
}

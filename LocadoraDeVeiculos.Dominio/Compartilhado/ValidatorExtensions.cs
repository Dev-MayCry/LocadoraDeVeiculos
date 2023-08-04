using FluentValidation;
using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.Compartilhado {
    public static class ValidatorExtensions {
        public static IRuleBuilderOptions<T, string> VerificadorDePlacas<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.SetValidator(new PlacasValidator<T>());
        }
    }
}

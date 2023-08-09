using FluentValidation;
using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.Compartilhado {
    public static class ValidatorExtensions {
        public static IRuleBuilderOptions<T, string> VerificadorDePlacas<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.SetValidator(new PlacasValidator<T>());
        }
        public static IRuleBuilderOptions<T, string> VerificadorDeEmails<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.SetValidator(new EmailValidator<T>());
        }
    }
}

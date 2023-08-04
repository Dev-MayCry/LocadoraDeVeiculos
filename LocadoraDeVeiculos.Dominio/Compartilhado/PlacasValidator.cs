using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado {
    public class PlacasValidator<T> : PropertyValidator<T, string> {
        public override string Name => "VerificadorDePlacasValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode) {
            return $"'{nomePropriedade}' deve ser composto por letras e números.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto) {
            nomePropriedade = contextoValidacao.DisplayName;

            if (string.IsNullOrEmpty(texto))
                return false;

            bool estaValido = Regex.IsMatch(texto, "([A-Z]{3}[0-9][0-9A-Z][0-9]{2})|([A-Z]{3}[0-9]{4})");

            return estaValido;
        }
    }
}

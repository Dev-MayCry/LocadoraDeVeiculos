using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado {
    public class EmailValidator<T> : PropertyValidator<T, string> {
        public override string Name => "VerificadorDeEmailsValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode) {
            return $"'{nomePropriedade}' deve ser em um formato de email válido.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto) {
            nomePropriedade = contextoValidacao.DisplayName;

            if (string.IsNullOrEmpty(texto))
                return false;

            bool estaValido = Regex.IsMatch(texto, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            return estaValido;
        }
    }
}

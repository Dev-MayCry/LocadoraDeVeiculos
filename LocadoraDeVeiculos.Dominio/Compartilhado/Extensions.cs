using System.ComponentModel;

namespace LocadoraDeVeiculos.Dominio.Compartilhado {
    internal class Extensions {
    }

    public static class EnumExtension {
        public static string GetDescription(this Enum enumValue) {
            var field = enumValue.GetType().GetField(enumValue.ToString());

            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                return attribute.Description;

            return "Anotação não informada";
        }
    }
}

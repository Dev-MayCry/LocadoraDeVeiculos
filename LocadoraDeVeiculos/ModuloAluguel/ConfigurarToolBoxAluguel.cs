using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public class ConfigurarToolBoxAluguel : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Aluguel";

        public override string TooltipInserir => "Inserir novo Aluguel";

        public override string TooltipEditar => "Editar um Aluguel existente";

        public override string TooltipExcluir => "Excluir um Aluguel existente";

        public override string TooltipConfigurar => "Configurar preços dos combustíveis";

        public override bool ConfigurarHabilitado => true;
    }
}

using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public class ConfigurarToolBoxAutomovel : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Automóveis";

        public override string TooltipInserir => "Inserir Automóvel";

        public override string TooltipEditar => "Editar Automóvel existente";

        public override string TooltipExcluir => "Excluir Automóvel existente";
        public override string TooltipFiltrar => "Filtrar Automóvel por Grupo";

        public override bool FiltrarHabilitado => true;
    }
}

using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel {
    public class ConfigurarToolBoxGrupoAutomovel : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Grupo de Automóveis";

        public override string TooltipInserir => "Inserir Grupo de Automóvel";

        public override string TooltipEditar => "Editar um Grupo de Automóvel existente";

        public override string TooltipExcluir => "Excluir um Grupo de Automóvel existente";
    }
}

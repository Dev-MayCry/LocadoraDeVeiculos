using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloParceiro {
    public class ConfigurarToolBoxParceiro: ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Parceiro";

        public override string TooltipInserir => "Inserir novo Parceiro";

        public override string TooltipEditar => "Editar um Parceiro existente";

        public override string TooltipExcluir => "Excluir um Parceiro existente";
    }
}

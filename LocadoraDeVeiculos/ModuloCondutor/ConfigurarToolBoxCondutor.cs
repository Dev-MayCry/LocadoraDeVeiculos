using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor {
    public class ConfigurarToolBoxCondutor : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Condutores";

        public override string TooltipInserir => "Inserir Condutor";

        public override string TooltipEditar => "Editar um Condutor existente";

        public override string TooltipExcluir => "Excluir um Condutor existente";
    }
}


using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario {
    public class ConfigurarToolBoxFuncionario : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Funcionário";

        public override string TooltipInserir => "Inserir novo Funcionário";

        public override string TooltipEditar => "Editar um Funcionário existente";

        public override string TooltipExcluir => "Excluir um Funcionário existente";
    }
}

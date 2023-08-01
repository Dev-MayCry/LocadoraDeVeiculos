using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloParceiro {
    public class ConfigurarToolBoxParceiro: ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Disciplinas";

        public override string TooltipInserir => "Inserir nova Disciplina";

        public override string TooltipEditar => "Editar uma Disciplina existente";

        public override string TooltipExcluir => "Excluir uma Disciplina existente";
    }
}

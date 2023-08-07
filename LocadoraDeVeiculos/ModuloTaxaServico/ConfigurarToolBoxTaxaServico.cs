using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    public class ConfigurarToolBoxTaxaServico : ConfiguracaoToolboxBase {
        public override string TipoCadastro => "Cadastro de Taxa de Serviços";

        public override string TooltipInserir => "Inserir Taxa de Serviço";

        public override string TooltipEditar => "Editar uma Taxa de Serviço existente";

        public override string TooltipExcluir => "Excluir uma Taxa de Serviço existente";
    }
}

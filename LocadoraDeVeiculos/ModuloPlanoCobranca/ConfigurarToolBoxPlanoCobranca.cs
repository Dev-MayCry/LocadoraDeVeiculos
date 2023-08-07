using LocadoraDeVeiculos.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    internal class ConfigurarToolBoxPlanoCobranca:ConfiguracaoToolboxBase {

        public override string TipoCadastro => "Cadastro de Plano de Cobrança";

        public override string TooltipInserir => "Inserir novo Plano de Cobrança";

        public override string TooltipEditar => "Editar um Plano de Cobrança existente";

        public override string TooltipExcluir => "Excluir um Plano de Cobrança existente";
    }
}

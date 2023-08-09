using LocadoraDeVeiculos.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.ModuloConfiguracaoDePrecos {
    internal class ControladorToolBoxConfigurador: ConfiguracaoToolboxBase {

        public override string TipoCadastro => "Configuração de Preços";

        public override string TooltipInserir => "Inserir Configurador de Preço";

        public override string TooltipEditar => "Editar Preços";

        public override string TooltipExcluir => "Excluir um Plano de Cobrança existente";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    public class ConfigurarToolBoxCliente
    {
        public override string TipoCadastro => "Cadastro de Cliente";

        public override string TooltipInserir => "Inserir novo Cliente";

        public override string TooltipEditar => "Editar um Cliente existente";

        public override string TooltipExcluir => "Excluir um Cliente existente";
    }
}

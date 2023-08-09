using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos {
    public class ConfiguracaoDePreco:EntidadeBase<ConfiguracaoDePreco> {

        public decimal PrecoGasolina { get; set; }
        public decimal PrecoAlcool { get; set; }
        public decimal PrecoGas { get; set; }
        public decimal PrecoDiesel { get; set; }

        public ConfiguracaoDePreco() {

        }

        public override void Atualizar(ConfiguracaoDePreco registro) {
            throw new NotImplementedException();
        }
    }
}

using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadorDeVeiculos.Infra.Arquivo.Compartilhado {
    public abstract class RepositorioArquivoBase {

        public abstract List<ConfiguracaoDePreco> ObterRegistros();

        public virtual void Inserir(ConfiguracaoDePreco configurador) {
            var registros = ObterRegistros();

            registros.Add(configurador);
        }

        public virtual void Editar(ConfiguracaoDePreco configurador) {
            var registros = ObterRegistros();

            foreach (var item in registros) {
                if (item.Id == configurador.Id) {
                    item.Atualizar(configurador);
                    break;
                }
            }
        }

        public virtual void Excluir(ConfiguracaoDePreco configurador) {
            var registros = ObterRegistros();

            registros.Remove(configurador);
        }

        public virtual List<ConfiguracaoDePreco> SelecionarTodos() {
            return ObterRegistros().ToList();
        }

       
    }
}

using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LocadorDeVeiculos.Infra.Arquivo.Compartilhado {

    [Serializable]
    public class GeradorTesteJsonContext : IContextoPersistencia {
        private readonly ISerializador serializador;

        public List<ConfiguracaoDePreco> PrecosCombustivel { get; set; }
        public GeradorTesteJsonContext() {
            PrecosCombustivel = new List<ConfiguracaoDePreco>();
           
        }


        public GeradorTesteJsonContext(ISerializador serializador) : this() {
            this.serializador = serializador;

            CarregarDados();
        }


        

        public void DesfazerAlteracoes() {
            CarregarDados();
        }

        public void GravarDados() {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados() {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.PrecosCombustivel.Any())
                this.PrecosCombustivel.AddRange(ctx.PrecosCombustivel);

        }
    }
}

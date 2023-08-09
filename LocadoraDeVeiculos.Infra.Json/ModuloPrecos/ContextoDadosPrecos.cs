using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Json.Serializadores;

namespace LocadoraDeVeiculos.Infra.Json.ModuloPrecos {
    [Serializable]
    public class ContextoDadosPrecos : IContextoPersistencia {

        private readonly SerializadorDadosEmJson serializador;

        public ContextoDadosPrecos() {
            Precos = new List<Precos>();
        }

        public ContextoDadosPrecos(SerializadorDadosEmJson serializador) : this() {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Precos> Precos { get; set; }

        public void DesfazerAlteracoes() {
            CarregarDados();
        }

        public void GravarDados() {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados() {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Precos.Any())
                this.Precos.AddRange(ctx.Precos);
        }
    }
}

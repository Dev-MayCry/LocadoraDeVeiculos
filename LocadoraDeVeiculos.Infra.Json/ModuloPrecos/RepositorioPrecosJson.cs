using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;

namespace LocadoraDeVeiculos.Infra.Json.ModuloPrecos {
    public class RepositorioPrecosJson {
        protected ContextoDadosPrecos contextoDados;

        public RepositorioPrecosJson(IContextoPersistencia contexto) {

            contextoDados = contexto as ContextoDadosPrecos;
        }

        public void Salvar(Precos registro) {
            var registros = ObterRegistros();
            var registroExistente = registros.FirstOrDefault(r => r.Id == registro.Id);

            if (registroExistente != null) {
                registroExistente.Atualizar(registro);
            } else {
                registros.Add(registro);
            }

            contextoDados.GravarDados();
        }

        public List<Precos> ObterRegistros() {
            return contextoDados.Precos;
        }
    }
}
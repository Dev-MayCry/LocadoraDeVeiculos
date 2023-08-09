using System.Text.Json;
using System.Text.Json.Serialization;
using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;

namespace LocadoraDeVeiculos.Infra.Json.ModuloConfigPreco {
    public class RepositorioConfiguradorPreco : IRepositorioConfiguracaoPreco {

        private const string NOME_ARQUIVO = "ArquivoConfiguracaoPreco.json";

        public ConfiguracaoDePreco configuracaoPreco { get; set; }

        public RepositorioConfiguradorPreco(bool carregarDados) {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarConfiguracaoPrecoEmArquivoJson(ConfiguracaoDePreco novoConfiguracaoPreco) {
            configuracaoPreco = novoConfiguracaoPreco;

            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(novoConfiguracaoPreco, ObterConfiguracoes()));
        }

        public ConfiguracaoDePreco ObterConfiguracaoPreco() {
            return configuracaoPreco;
        }

        private void CarregarDoArquivoJson() {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO) && File.ReadAllText(NOME_ARQUIVO).Length > 0)
                configuracaoPreco = JsonSerializer.Deserialize<ConfiguracaoDePreco>(File.ReadAllText(NOME_ARQUIVO), config);
            else
                configuracaoPreco = new ConfiguracaoDePreco();
        }

        private static JsonSerializerOptions ObterConfiguracoes() {
            JsonSerializerOptions opcoes = new();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }

        public void Inserir(ConfiguracaoDePreco novoRegistro) {
            throw new NotImplementedException();
        }

        public void Editar(ConfiguracaoDePreco registro) {
            throw new NotImplementedException();
        }

        public void Excluir(ConfiguracaoDePreco registro) {
            throw new NotImplementedException();
        }

        public bool Existe(ConfiguracaoDePreco registro) {
            throw new NotImplementedException();
        }

        public List<ConfiguracaoDePreco> SelecionarTodos() {
            List<ConfiguracaoDePreco> lista;
            lista.Add(configuracaoPreco);
            return lista;
            }

            public ConfiguracaoDePreco SelecionarPorId(Guid id) {
            throw new NotImplementedException();
        }
    }
}

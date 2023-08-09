using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LocadorDeVeiculos.Infra.Arquivo.Compartilhado {
    internal class SerializadorDadosEmJson : ISerializador {
        private const string arquivo = @"C:\temp\dados.json";

        public GeradorTesteJsonContext CarregarDadosDoArquivo() {
            if (File.Exists(arquivo) == false)
                return new GeradorTesteJsonContext();

            string json = File.ReadAllText(arquivo);

            return JsonSerializer.Deserialize<GeradorTesteJsonContext>(json);
        }

        public void GravarDadosEmArquivo(GeradorTesteJsonContext dados) {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(dados, config);

            File.WriteAllText(arquivo, json);
        }
    }
}

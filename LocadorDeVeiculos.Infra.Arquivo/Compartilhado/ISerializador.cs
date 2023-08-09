

namespace LocadorDeVeiculos.Infra.Arquivo.Compartilhado {
    public interface ISerializador {
        GeradorTesteJsonContext CarregarDadosDoArquivo();

        void GravarDadosEmArquivo(GeradorTesteJsonContext dados);
    }
}

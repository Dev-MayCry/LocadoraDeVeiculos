namespace LocadoraDeVeiculos.Dominio.ModuloAluguel {
    public interface IGeradorArquivo {
        void GerarAluguel(Aluguel aluguel, bool encerrado);
    }
}

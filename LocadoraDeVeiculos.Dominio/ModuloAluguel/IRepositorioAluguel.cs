using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel {
    public interface IRepositorioAluguel : IRepositorio<Aluguel> {
        List<Aluguel> SelecionarPorEncerrado();

        Aluguel SelecionarPorAutomovel(Automovel automovel);

        Aluguel SelecionarPorCondutor(Condutor condutor);
    }
}

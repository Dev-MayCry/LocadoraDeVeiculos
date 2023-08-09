using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel {
    public interface IRepositorioAluguel : IRepositorio<Aluguel> {
        List<Aluguel> SelecionarPorEncerrado();
    }
}

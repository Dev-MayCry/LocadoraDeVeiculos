using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel {
    public interface IRepositorioAutomovel : IRepositorio<Automovel> {
        Automovel SelecionarPorPlaca(string placa);
    }
}

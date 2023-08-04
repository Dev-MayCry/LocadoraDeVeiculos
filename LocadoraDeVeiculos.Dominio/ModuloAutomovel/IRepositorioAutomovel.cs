using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel {
    public interface IRepositorioAutomovel : IRepositorio<Automovel> {
        Automovel SelecionarPorPlaca(string placa);

        List<Automovel> SelecionarPorGrupo(GrupoAutomovel grupo);
    }
}

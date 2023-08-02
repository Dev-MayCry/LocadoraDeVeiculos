using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel {
    public interface IRepositorioGrupoAutomovel : IRepositorio<GrupoAutomovel> {
        GrupoAutomovel SelecionarPorNome(string nome);
    }
}

using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca {
    public interface IRepositorioPlanoCobranca : IRepositorio<PlanoCobranca> {

        PlanoCobranca SelecionarPorNome(string nome);

        List<PlanoCobranca> SelecionarPorGrupo(GrupoAutomovel grupo);

    }
}


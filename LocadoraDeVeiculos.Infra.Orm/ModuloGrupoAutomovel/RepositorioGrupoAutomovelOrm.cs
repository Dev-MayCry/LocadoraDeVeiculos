using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel {
    public class RepositorioGrupoAutomovelOrm : RepositorioBaseORM<GrupoAutomovel>, IRepositorioGrupoAutomovel {
        public RepositorioGrupoAutomovelOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public GrupoAutomovel SelecionarPorNome(string nome) {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

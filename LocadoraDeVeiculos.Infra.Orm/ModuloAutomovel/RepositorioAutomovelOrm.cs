using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel {
    public class RepositorioAutomovelOrm : RepositorioBaseORM<Automovel>, IRepositorioAutomovel {
        public RepositorioAutomovelOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public Automovel SelecionarPorPlaca(string placa) {
            return registros.FirstOrDefault(x => x.Placa == placa);
        }
    }
}

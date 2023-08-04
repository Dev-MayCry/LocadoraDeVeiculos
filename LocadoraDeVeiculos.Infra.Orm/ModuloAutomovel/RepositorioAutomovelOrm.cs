using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel {
    public class RepositorioAutomovelOrm : RepositorioBaseORM<Automovel>, IRepositorioAutomovel {
        public RepositorioAutomovelOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public List<Automovel> SelecionarTodos() {
            return registros.Include(x => x.GrupoAutomovel).ToList();
        }

        public Automovel SelecionarPorPlaca(string placa) {
            return registros.FirstOrDefault(x => x.Placa == placa);
        }

        public List<Automovel> SelecionarPorGrupo(GrupoAutomovel grupo) {
            return registros.Where(x => x.GrupoAutomovel == grupo).ToList();

        }
    }
}

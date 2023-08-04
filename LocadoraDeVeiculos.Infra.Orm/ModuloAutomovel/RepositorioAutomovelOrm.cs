using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
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
    }
}

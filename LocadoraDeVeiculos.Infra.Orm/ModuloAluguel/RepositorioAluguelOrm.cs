using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel {
    public class RepositorioAluguelOrm : RepositorioBaseORM<Aluguel>, IRepositorioAluguel {
        public RepositorioAluguelOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public List<Aluguel> SelecionarTodos() {
            return registros.Include(x => x.GrupoAutomovel)
                .Include(x => x.Funcionario)
                .Include(x => x.Cliente)
                .Include(x => x.Condutor)
                .Include(x => x.GrupoAutomovel)
                .Include(x => x.Automovel)
                .Include(x => x.PlanoCobranca)
                .Include(x => x.Cupom)
                .ToList();
        }

        public List<Aluguel> SelecionarPorEncerrado() {
            return registros.Where(x => x.Encerrado == true).ToList();
        }
    }
}

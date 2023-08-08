using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor {
    public class RepositorioCondutorOrm : RepositorioBaseORM<Condutor>, IRepositorioCondutor {
        public RepositorioCondutorOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public List<Condutor> SelecionarTodos() {
            return registros.Include(x => x.Cliente).ToList();
        }

        public Condutor SelecionarPorNome(string nome) {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

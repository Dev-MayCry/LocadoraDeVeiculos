using LocadoraDeVeiculos.Dominio.ModuloCupom;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupom
{
    public class RepositorioCupomOrm : RepositorioBaseORM<Cupom>, IRepositorioCupom
    {
        public RepositorioCupomOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }
        public Cupom SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
        public List<Cupom> SelecionarTodos()
        {
            return registros.Include(x => x.Parceiro).ToList();
        }
    }
}

using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.Compartilhado;
namespace LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.ModuloCupom
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
    }
}

using LocadoraDeVeiculos.Dominio.ModuloCliente;
namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class RepositorioClienteOrm : RepositorioBaseORM<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }
        public Cliente SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
       
    }
}

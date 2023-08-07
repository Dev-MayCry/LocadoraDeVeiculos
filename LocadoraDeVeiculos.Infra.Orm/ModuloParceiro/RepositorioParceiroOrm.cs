using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;


namespace LocadoraDeVeiculos.Infra.Orm.ModuloParceiro {
    public class RepositorioParceiroOrm : RepositorioBaseORM<Parceiro>, IRepositorioParceiro
    {
        public RepositorioParceiroOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }

        public void Inserir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Parceiro SelecionarPorNome(string nome)
        {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

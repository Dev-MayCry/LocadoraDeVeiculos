using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxaServico {
    public class RepositorioTaxaServicoOrm : RepositorioBaseORM<TaxaServico>, IRepositorioTaxaServico {
        public RepositorioTaxaServicoOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public TaxaServico SelecionarPorNome(string nome) => registros.FirstOrDefault(x => x.Nome == nome);
    }
}

using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxaServico {
    public interface IRepositorioTaxaServico : IRepositorio<TaxaServico>{
        TaxaServico SelecionarPorNome(string nome);
    }
}

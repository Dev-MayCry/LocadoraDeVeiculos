using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxaServico {
    public class TaxaServico : EntidadeBase<TaxaServico>{
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public TipoPlanoCalculoEnum TipoPlano { get; set; }

        public TaxaServico(string nome, decimal preco, TipoPlanoCalculoEnum tipoPlano) {
            Nome = nome;
            Preco = preco;
            TipoPlano = tipoPlano;
        }
        public TaxaServico(Guid id, string nome, decimal preco, TipoPlanoCalculoEnum tipoPlano) {
            Id = id;
            Nome = nome;
            Preco = preco;
            TipoPlano = tipoPlano;
        }

        public override void Atualizar(TaxaServico registro) {
            Nome = registro.Nome;
            Preco = registro.Preco;
            TipoPlano = registro.TipoPlano;
        }

        public override string? ToString() {
            return Nome;
        }
    }
}

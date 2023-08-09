using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel {
    public class Aluguel : EntidadeBase<Aluguel>{
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public Condutor Condutor { get; set; }
        public GrupoAutomovel GrupoAutomovel { get; set;}
        public Automovel Automovel { get; set; }
        public PlanoCobranca PlanoCobranca { get; set;}
        public int KmAutomovel { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public Cupom Cupom { get; set; }
        public List<TaxaServico> TaxasSelecionadas { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int KmPercorrido { get; set; }
        public TipoNivelTanqueEnum NivelTanque { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Encerrado { get; set; } = false;

        public Aluguel() {}

        public Aluguel(Funcionario funcionario, Cliente cliente, Condutor condutor, GrupoAutomovel grupoAutomovel, Automovel automovel, PlanoCobranca planoCobranca, int kmAutomovel, DateTime dataLocacao, DateTime dataDevolucaoPrevista, Cupom cupom, List<TaxaServico> taxasSelecionadas, DateTime dataDevolucao, decimal valorTotal) {
            Funcionario = funcionario;
            Cliente = cliente;
            Condutor = condutor;
            GrupoAutomovel = grupoAutomovel;
            Automovel = automovel;
            PlanoCobranca = planoCobranca;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            Cupom = cupom;
            TaxasSelecionadas = taxasSelecionadas;
            DataDevolucao = dataDevolucao;
            ValorTotal = valorTotal;
        }
        public Aluguel(Guid id, Funcionario funcionario, Cliente cliente, Condutor condutor, GrupoAutomovel grupoAutomovel, Automovel automovel, PlanoCobranca planoCobranca, int kmAutomovel, DateTime dataLocacao, DateTime dataDevolucaoPrevista, Cupom cupom, List<TaxaServico> taxasSelecionadas, DateTime dataDevolucao, decimal valorTotal) {
            Id = id;
            Funcionario = funcionario;
            Cliente = cliente;
            Condutor = condutor;
            GrupoAutomovel = grupoAutomovel;
            Automovel = automovel;
            PlanoCobranca = planoCobranca;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            Cupom = cupom;
            TaxasSelecionadas = taxasSelecionadas;
            DataDevolucao = dataDevolucao;
            ValorTotal = valorTotal;
        }

        public Aluguel(Funcionario funcionario, Cliente cliente, Condutor condutor, GrupoAutomovel grupoAutomovel, Automovel automovel, PlanoCobranca planoCobranca, int kmAutomovel, DateTime dataLocacao, DateTime dataDevolucaoPrevista, Cupom cupom, List<TaxaServico> taxasSelecionadas, DateTime dataDevolucao, int kmPercorrido, TipoNivelTanqueEnum nivelTanque, decimal valorTotal) {
            Funcionario = funcionario;
            Cliente = cliente;
            Condutor = condutor;
            GrupoAutomovel = grupoAutomovel;
            Automovel = automovel;
            PlanoCobranca = planoCobranca;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            Cupom = cupom;
            TaxasSelecionadas = taxasSelecionadas;
            DataDevolucao = dataDevolucao;
            KmPercorrido = kmPercorrido;
            NivelTanque = nivelTanque;
            ValorTotal = valorTotal;
        }
        public Aluguel(Guid id, Funcionario funcionario, Cliente cliente, Condutor condutor, GrupoAutomovel grupoAutomovel, Automovel automovel, PlanoCobranca planoCobranca, int kmAutomovel, DateTime dataLocacao, DateTime dataDevolucaoPrevista, Cupom cupom, List<TaxaServico> taxasSelecionadas, DateTime dataDevolucao, int kmPercorrido, TipoNivelTanqueEnum nivelTanque, decimal valorTotal) {
            Id = id;
            Funcionario = funcionario;
            Cliente = cliente;
            Condutor = condutor;
            GrupoAutomovel = grupoAutomovel;
            Automovel = automovel;
            PlanoCobranca = planoCobranca;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            Cupom = cupom;
            TaxasSelecionadas = taxasSelecionadas;
            DataDevolucao = dataDevolucao;
            KmPercorrido = kmPercorrido;
            NivelTanque = nivelTanque;
            ValorTotal = valorTotal;
        }

        public override void Atualizar(Aluguel registro) {
            Funcionario = registro.Funcionario;
            Cliente = registro.Cliente;
            Condutor = registro.Condutor;
            GrupoAutomovel = registro.GrupoAutomovel;
            Automovel = registro.Automovel;
            PlanoCobranca = registro.PlanoCobranca;
            KmAutomovel = registro.KmAutomovel;
            DataLocacao = registro.DataLocacao;
            DataDevolucaoPrevista = registro.DataDevolucaoPrevista;
            Cupom = registro.Cupom;
            TaxasSelecionadas = registro.TaxasSelecionadas;
            DataDevolucao = registro.DataDevolucao;
            KmPercorrido = registro.KmPercorrido;
            NivelTanque = registro.NivelTanque;
            ValorTotal = registro.ValorTotal;
        }
    }
}

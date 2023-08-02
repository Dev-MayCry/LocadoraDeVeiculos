using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using System.Drawing;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; } 
        public Parceiro Parceiro { get; set; }
        public DateTime DataValidade { get; set; } = DateTime.Now;
        public override void Atualizar(Cupom registro)
        {
            Nome = registro.Nome;
            Valor = registro.Valor;
            Parceiro = registro.Parceiro;
            DataValidade = registro.DataValidade;
        }
        public Cupom()
        {

        }
        public Cupom(Guid id, string nome) : this(nome)
        {
            Id = id;
        }
       
        public Cupom(string Nome)
        {
            this.Nome = Nome;          
        }
        public Cupom(Guid id, string nome, decimal valor,Parceiro parceiro, DateTime dataValidade) : this(nome)
        {
            Id = id;
            Valor = valor;
            Parceiro = parceiro;
            DataValidade = dataValidade;
        }
        public Cupom(Guid id, string nome, decimal valor) : this(nome)
        {
            Id = id;
            Valor = valor; 
        }

        public Cupom(string nome, decimal valor) : this(nome)
        {
            Valor = valor; 
        }
        
    }
}

using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Parceiro Parceiro { get; set; }
        public DateTime DataValidade { get; set; }
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
        public Cupom(int id, string nome) : this(nome)
        {
            Id = id;
        }
       
        public Cupom(string Nome)
        {
            this.Nome = Nome;          
        }
        public Cupom(int id, string nome, double valor,Parceiro parceiro, DateTime dataValidade) : this(nome)
        {
            Id = id;
            Valor = valor;
            Parceiro = parceiro;
            DataValidade = dataValidade;
        }
        public Cupom(int id, string nome, double valor) : this(nome)
        {
            Id = id;
            Valor = valor; 
        }

        public Cupom(string nome, double valor) : this(nome)
        {
            Valor = valor; 
        }
        



    }
}

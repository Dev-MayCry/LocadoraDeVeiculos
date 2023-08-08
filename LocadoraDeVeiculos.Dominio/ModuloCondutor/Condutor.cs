using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor {
    public class Condutor : EntidadeBase<Condutor>{

        public Cliente Cliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public DateTime DataValidade { get; set; }

        public Condutor() { }

        public Condutor(Cliente cliente, string nome, string email, string telefone, string cpf, string cnh, DateTime dataValidade) {
            Cliente = cliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Cnh = cnh;
            DataValidade = dataValidade;
        } 
        public Condutor(Guid id, Cliente cliente, string nome, string email, string telefone, string cpf, string cnh, DateTime dataValidade) {
            Id = id;
            Cliente = cliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Cnh = cnh;
            DataValidade = dataValidade;
        }

        public override void Atualizar(Condutor registro) {
            Cliente = registro.Cliente;
            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            Cpf = registro.Cpf;
            Cnh = registro.Cnh;
            DataValidade = registro.DataValidade;
        }

        public override string ToString() {
            return Nome;
        }
    }
}

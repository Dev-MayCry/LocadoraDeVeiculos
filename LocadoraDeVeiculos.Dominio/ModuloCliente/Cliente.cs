using LocadoraDeVeiculos.Dominio.Compartilhado;


namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
     
        public string Nome { get; set; }
        public string Email { get; set; }      
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string NumeroDaCasa { get; set; }
        public string Cidade { get; set; }
        public string Estado{ get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }  
        public TipoClienteEnum  TipoCliente { get; set; }
        
        //public enum   TipoDePessoa { get; set; }
        public override void Atualizar(Cliente registro)
        {
            
            Nome = registro.Nome;
            Email = registro.Email;           
            Telefone = registro.Telefone;
            Cpf = registro.Cpf; 
            Cnpj = registro.Cnpj;  
            Cidade = registro.Cidade;
            Bairro = registro.Bairro;
            Rua = registro.Rua;
            NumeroDaCasa = registro.NumeroDaCasa;
            Estado = registro.Estado;
            TipoCliente = registro.TipoCliente;
        }
        public Cliente()
        {

        }

        public Cliente(string Nome)
        {
            this.Nome = Nome;
        }
        public Cliente( string nome,string email,string telefone ,string cpf,string cnpj,string cidade,string bairro,string rua,string numeroDaCasa,string estado,TipoClienteEnum tipoCliente) : this(nome)
        {                 
            Nome = nome;
            Email = email; 
            Telefone = telefone;
            Cpf = cpf;
            Cnpj = cnpj;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroDaCasa= numeroDaCasa;  
            Estado = estado;
            TipoCliente= tipoCliente;
        }
        public Cliente(Guid id,string nome, string email, string telefone ,string cpf, string cnpj, string cidade, string bairro, string rua, string numeroDaCasa, string estado, TipoClienteEnum tipoCliente) : this(nome)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Cnpj = cnpj;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroDaCasa = numeroDaCasa;
            Estado = estado;
            TipoCliente = tipoCliente;
        }

        public override string? ToString() {
            return Nome;
        }
    }
}

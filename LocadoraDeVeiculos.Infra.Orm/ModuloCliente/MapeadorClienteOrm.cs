using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class MapeadorClienteOrm : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> clienteBuilder)
        {

            clienteBuilder.ToTable("TBCliente");

            clienteBuilder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            clienteBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Email).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Telefone).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Cpf).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Cnpj).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Cidade).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Bairro).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Rua).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.NumeroDaCasa).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Estado).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.TipoCliente).HasConversion<int>().IsRequired();
          
        }
    }
    //Nome = registro.Nome;
    //        Email = registro.Email;
    //        Endereco = registro.Endereco;
    //        Telefone = registro.Telefone;
    //        Cpf = registro.Cpf; 
    //        Cnpj = registro.Cnpj;  
    //        Cidade = registro.Cidade;
    //        Bairro = registro.Bairro;
    //        Rua = registro.Rua;
    //        NumeroDaCasa = registro.NumeroDaCasa;
    //        Estado = registro.Estado;
    //        TipoDoCliente = registro.TipoDoCliente;
}

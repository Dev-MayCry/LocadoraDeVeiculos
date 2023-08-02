using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class MapeadorClienteOrm : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> clienteBuilder)
        {

            clienteBuilder.ToTable("TBCliente");

            clienteBuilder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            clienteBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }

}

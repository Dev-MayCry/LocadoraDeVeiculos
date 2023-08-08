using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor
{
    public class MapeadorCondutorOrm : IEntityTypeConfiguration<Condutor> {
        public void Configure(EntityTypeBuilder<Condutor> condutorBuilder) {
            
            condutorBuilder.ToTable("TBCondutor");

            condutorBuilder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            condutorBuilder.HasOne(c => c.Cliente)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBCondutor_TBCliente")
                .OnDelete(DeleteBehavior.NoAction);

            condutorBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            condutorBuilder.Property(c => c.Email).HasColumnType("varchar(100)").IsRequired();

            condutorBuilder.Property(c => c.Telefone).HasColumnType("varchar(100)").IsRequired();

            condutorBuilder.Property(c => c.Cpf).HasColumnType("varchar(100)").IsRequired();

            condutorBuilder.Property(c => c.Cnh).HasColumnType("varchar(100)").IsRequired();

            condutorBuilder.Property(c => c.DataValidade).HasColumnType("Date").IsRequired();

        }
    }
}
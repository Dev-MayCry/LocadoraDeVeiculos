using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupom
{
    public class MapeadorCupomOrm : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> cupomBuilder)
        {
            cupomBuilder.ToTable("TBCupom");

            cupomBuilder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            cupomBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            cupomBuilder.Property(c => c.Valor).HasColumnType("decimal").IsRequired();

            cupomBuilder.HasOne(c => c.Parceiro).WithMany().IsRequired().HasConstraintName("FK_TBCupom_TBParceiro").OnDelete(DeleteBehavior.NoAction);

            cupomBuilder.Property(c => c.DataValidade).IsRequired();
        }
    }
}

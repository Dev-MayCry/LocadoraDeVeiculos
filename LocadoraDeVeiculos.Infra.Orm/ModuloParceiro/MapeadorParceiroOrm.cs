

using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloParceiro
{
    public class MapeadorParceiroOrm : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> parceiroBuilder)
        {

            parceiroBuilder.ToTable("TBParceiro");

            parceiroBuilder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            parceiroBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }
}

using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxaServico {
    public class MapeadorTaxaServicoOrm : IEntityTypeConfiguration<TaxaServico> {
        public void Configure(EntityTypeBuilder<TaxaServico> taxaServicoBuilder) {
            taxaServicoBuilder.ToTable("TBTaxaServico");

            taxaServicoBuilder.Property(t => t.Id).IsRequired().ValueGeneratedNever();

            taxaServicoBuilder.Property(t => t.Nome).HasColumnType("varchar(100)").IsRequired();

            taxaServicoBuilder.Property(t => t.Preco).HasColumnType("decimal").IsRequired();

            taxaServicoBuilder.Property(t => t.TipoPlano).HasConversion<int>().IsRequired();
        }
    }


}

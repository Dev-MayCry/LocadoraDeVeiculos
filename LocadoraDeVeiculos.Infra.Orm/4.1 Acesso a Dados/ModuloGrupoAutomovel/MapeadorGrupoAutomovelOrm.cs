using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.ModuloGrupoAutomovel {
    public class MapeadorGrupoAutomovelOrm : IEntityTypeConfiguration<GrupoAutomovel>{
        public void Configure(EntityTypeBuilder<GrupoAutomovel> grupoAutomovelBuilder) {

            grupoAutomovelBuilder.ToTable("TBGrupoAutomovel");

            grupoAutomovelBuilder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            grupoAutomovelBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }
}

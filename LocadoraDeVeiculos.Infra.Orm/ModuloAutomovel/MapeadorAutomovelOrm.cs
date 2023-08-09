using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel {
    public class MapeadorAutomovelOrm : IEntityTypeConfiguration<Automovel> {
        public void Configure(EntityTypeBuilder<Automovel> automovelBuilder) {
            
            automovelBuilder.ToTable("TBAutomovel");

            automovelBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();

            automovelBuilder.Property(a => a.Placa).HasColumnType("varchar(100)").IsRequired();
            
            automovelBuilder.Property(a => a.Modelo).HasColumnType("varchar(100)").IsRequired();

            automovelBuilder.Property(a => a.Marca).HasColumnType("varchar(100)").IsRequired();

            automovelBuilder.Property(a => a.Cor).HasColumnType("varchar(100)").IsRequired();

            automovelBuilder.Property(a => a.TipoCombustivel).HasConversion<int>().IsRequired();

            automovelBuilder.Property(a => a.CapacidadeLitros).HasColumnType("int").IsRequired();

            automovelBuilder.Property(a => a.Quilometragem).HasColumnType("int").IsRequired();
            
            automovelBuilder.Property(a => a.Ano).HasColumnType("int").IsRequired();

            automovelBuilder.HasOne(a => a.GrupoAutomovel)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAutomovel_TBGrupoAutomovel")
                .OnDelete(DeleteBehavior.NoAction);

            automovelBuilder.Property(a => a.Foto).HasColumnType("varbinary(max)").IsRequired(false);
        }
    }
}
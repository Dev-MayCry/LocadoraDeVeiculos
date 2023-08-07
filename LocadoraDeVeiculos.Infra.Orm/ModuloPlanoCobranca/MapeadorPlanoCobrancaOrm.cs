using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca {
    public class MapeadorPlanoCobrancaOrm : IEntityTypeConfiguration<PlanoCobranca> {
        public void Configure(EntityTypeBuilder<PlanoCobranca> planoCobrancaBuilder) {

            planoCobrancaBuilder.ToTable("TBPlanoCobranca");
            planoCobrancaBuilder.Property(p => p.Id).IsRequired(true).ValueGeneratedNever();
            planoCobrancaBuilder.Property(p => p.Id).IsRequired(true).ValueGeneratedNever();
            planoCobrancaBuilder.Property(p => p.tipo).HasConversion<int>().IsRequired();
            planoCobrancaBuilder.Property(p=> p.PrecoDiaria).HasColumnType("decimal").IsRequired(true);
            planoCobrancaBuilder.Property(p=> p.PrecoKm).HasColumnType("decimal").IsRequired(true);
            planoCobrancaBuilder.Property(p=> p.KmDisponiveis).HasColumnType("int").IsRequired(true);

            planoCobrancaBuilder.HasOne(p => p.grupo)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBPlanoCobranca_TBGrupoAutomoveis")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

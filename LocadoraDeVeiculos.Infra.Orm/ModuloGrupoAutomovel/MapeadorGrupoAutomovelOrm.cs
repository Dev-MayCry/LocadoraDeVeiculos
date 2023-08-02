﻿using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel
{
    public class MapeadorGrupoAutomovelOrm : IEntityTypeConfiguration<GrupoAutomovel>
    {
        public void Configure(EntityTypeBuilder<GrupoAutomovel> grupoAutomovelBuilder)
        {

            grupoAutomovelBuilder.ToTable("TBGrupoAutomovel");

            grupoAutomovelBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();

            grupoAutomovelBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }
}

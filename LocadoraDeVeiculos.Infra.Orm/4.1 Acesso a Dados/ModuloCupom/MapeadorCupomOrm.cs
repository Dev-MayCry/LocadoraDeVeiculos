using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LocadoraDeVeiculos.Dominio.ModuloCupom;

namespace LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.ModuloCupom
{
    public class MapeadorCupomOrm : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> cupomBuilder)
        {
            cupomBuilder.ToTable("TBCupom");

            cupomBuilder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();

            cupomBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }  
}

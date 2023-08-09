using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel {
    public class MapeadorAluguelOrm : IEntityTypeConfiguration<Aluguel> {
        public void Configure(EntityTypeBuilder<Aluguel> aluguelBuilder) {
            aluguelBuilder.ToTable("TBAluguel");

            aluguelBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();

            aluguelBuilder.HasOne(a => a.Funcionario)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBFuncionario")
                .OnDelete(DeleteBehavior.NoAction);
            
            aluguelBuilder.HasOne(a => a.Cliente)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBCliente")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.Condutor)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBCondutor")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.GrupoAutomovel)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBGrupoAutomovel")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.Automovel)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBAutomovel")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.PlanoCobranca)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBPlanoCobranca")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.Property(a => a.KmAutomovel).HasColumnType("int").IsRequired();

            aluguelBuilder.Property(a => a.DataLocacao).HasColumnType("Date").IsRequired();

            aluguelBuilder.Property(a => a.DataDevolucaoPrevista).HasColumnType("Date").IsRequired();

            aluguelBuilder.HasOne(a => a.Cupom)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBAluguel_TBCupom")
                .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasMany(a => a.TaxasSelecionadas)
                .WithMany()
                .UsingEntity(x => x.ToTable("TBAluguel_TBTaxaServico"));

            aluguelBuilder.Property(a => a.DataDevolucao).HasColumnType("Date").IsRequired();

            aluguelBuilder.Property(a => a.KmPercorrido).HasColumnType("int").IsRequired();

            aluguelBuilder.Property(a => a.NivelTanque).HasConversion<int>().IsRequired();

            aluguelBuilder.Property(a => a.ValorTotal).HasColumnType("decimal").IsRequired();
        }
    }
}
/*          Funcionario = funcionario;
            Cliente = cliente;
            Condutor = condutor;
            GrupoAutomovel = grupoAutomovel;
            Automovel = automovel;
            PlanoCobranca = planoCobranca;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            Cupom = cupom;
            TaxasSelecionadas = taxasSelecionadas;
            DataDevolucao = dataDevolucao;
            KmPercorrido = kmPercorrido;
            NivelTanque = nivelTanque;
            TaxasAdicionais = taxasAdicionais;
            ValorTotalPrevisto = valorTotalPrevisto;
            ValorTotal = valorTotal;*/
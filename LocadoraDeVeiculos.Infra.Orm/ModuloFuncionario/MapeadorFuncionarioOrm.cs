using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario
{
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> funcionarioBuilder)
        {

            funcionarioBuilder.ToTable("TBFuncionario");

           
            funcionarioBuilder.Property(f => f.Id).IsRequired().ValueGeneratedNever();

            funcionarioBuilder.Property(f => f.Nome).HasColumnType("varchar(100)").IsRequired();

            funcionarioBuilder.Property(f => f.DataAdmissao).HasColumnType("Date").IsRequired();

            funcionarioBuilder.Property(f => f.Salario).HasColumnType("Decimal").IsRequired();

        }
    }
}

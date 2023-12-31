﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;

namespace LocadoraDeVeiculos.Infra.Orm.Compartilhado
{
    public class LocadoraDeVeiculosDbContext : DbContext
    {


        public LocadoraDeVeiculosDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            ILoggerFactory loggerFactory = LoggerFactory.Create((x) =>
            {
                x.AddSerilog(Log.Logger);
            });

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            Assembly assembly = typeof(LocadoraDeVeiculosDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }


        public static class LocadoraDeVeiculosMigradorBancoDados
        {
            public static bool AtualizarBancoDados(DbContext db)
            {
                var qtdMigracoesPendentes = db.Database.GetPendingMigrations().Count();

                if (qtdMigracoesPendentes == 0)
                    return false;

                db.Database.Migrate();

                return true;
            }
        }
    }
}

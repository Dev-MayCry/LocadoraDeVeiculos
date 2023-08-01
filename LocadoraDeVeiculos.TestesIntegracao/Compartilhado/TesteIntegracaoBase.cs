using FizzWare.NBuilder;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.TestesIntegracao.Compartilhado
{
    public class TesteIntegracaoBase {

        protected IRepositorioParceiro repositorioParceiro;
        protected IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        protected IRepositorioFuncionario repositorioFuncionario;

        public TesteIntegracaoBase() {

            LimparTabelas();

            string connectionString = ObterConnectionString();
            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            repositorioGrupoAutomovel = new RepositorioGrupoAutomovelOrm(dbContext);
            repositorioFuncionario = new RepositorioFuncionarioOrm(dbContext);
            

            BuilderSetup.SetCreatePersistenceMethod<Parceiro>(repositorioParceiro.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<GrupoAutomovel>(repositorioGrupoAutomovel.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Funcionario>(repositorioFuncionario.Inserir);
            
        }

        protected static void LimparTabelas() {
            string? connectionString = ObterConnectionString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string sqlLimpezaTabela =
                @"
                DELETE FROM [DBO].[TBPARCEIRO]
                DELETE FROM [DBO].[TBGRUPOAUTOMOVEL]
                DELETE FROM [DBO].[TBFUNCIONARIO];
                ";
            SqlCommand comando = new SqlCommand(sqlLimpezaTabela, sqlConnection);

            sqlConnection.Open();

            comando.ExecuteNonQuery();

            sqlConnection.Close();
        }

        protected static string ObterConnectionString() {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            return configuracao.GetConnectionString("SqlServer");

        }
    }
}

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
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.TestesIntegracao.Compartilhado
{
    public class TesteIntegracaoBase {

        protected IRepositorioParceiro repositorioParceiro;
        protected IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        protected IRepositorioFuncionario repositorioFuncionario;
        protected IRepositorioAutomovel repositorioAutomovel;
        protected IRepositorioPlanoCobranca repositorioPlanoCobranca;
       

        public TesteIntegracaoBase() {

            LimparTabelas();

            string connectionString = ObterConnectionString();
            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            repositorioGrupoAutomovel = new RepositorioGrupoAutomovelOrm(dbContext);
            repositorioFuncionario = new RepositorioFuncionarioOrm(dbContext);
            repositorioAutomovel = new RepositorioAutomovelOrm(dbContext);
            
            
            repositorioPlanoCobranca = new RepositorioPlanoCobrancaOrm(dbContext);



            BuilderSetup.SetCreatePersistenceMethod<Parceiro>(repositorioParceiro.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<GrupoAutomovel>(repositorioGrupoAutomovel.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Funcionario>(repositorioFuncionario.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Automovel>(repositorioAutomovel.Inserir);
            
            BuilderSetup.SetCreatePersistenceMethod<PlanoCobranca>(repositorioPlanoCobranca.Inserir);

        }

        protected static void LimparTabelas() {
            string? connectionString = ObterConnectionString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string sqlLimpezaTabela =
                @"
                DELETE FROM [DBO].[TBPLANOCOBRANCA];
                DELETE FROM [DBO].[TBPARCEIRO];
                DELETE FROM [DBO].[TBGRUPOAUTOMOVEL];
                DELETE FROM [DBO].[TBFUNCIONARIO];
                DELETE FROM [DBO].[TBAUTOMOVEL];
              
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

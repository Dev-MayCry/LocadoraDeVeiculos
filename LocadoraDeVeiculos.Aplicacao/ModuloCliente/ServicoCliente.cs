using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloCliente
{
    public class ServicoCliente
    {

        private IRepositorioCliente repositorioCliente;
        private IValidadorCliente validadorCliente;

        public ServicoCliente(IRepositorioCliente repositorioCliente, IValidadorCliente validadorCliente)
        {

            this.repositorioCliente = repositorioCliente;
            this.validadorCliente = validadorCliente;

        }

        public Result Inserir(Cliente cliente)
        {
            Log.Debug("Tentando inserir Cliente...{@d}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioCliente.Inserir(cliente);

                Log.Debug("Cliente {ClienteId} inserido com sucesso", cliente.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Cliente";

                Log.Error(exc, msgErro + "{@d}", cliente);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Cliente cliente)
        {
            Log.Debug("Tentando editar Cliente...{@d}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCliente.Editar(cliente);

                Log.Debug("Cliente {ClienteId} editado com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Cliente";

                Log.Error(exc, msgErro + "{@d}", cliente);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Cliente cliente)
        {
            Log.Debug("Tentando excluir Cliente...{@d}", cliente);

            try
            {
                bool clienteExiste = repositorioCliente.Existe(cliente);

                if (clienteExiste == false)
                {
                    Log.Warning("Cliente {ClienteId} não encontrado para excluir", cliente.Id);

                    return Result.Fail("Cliente não encontrado");
                }

                repositorioCliente.Excluir(cliente);

                Log.Debug("Cliente {ClienteId} excluído com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBMateria_TBCliente"))
                    msgErro = "Esta cliente está relacionado com uma locação e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir Cliente";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {ClienteId}", cliente.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarCliente(Cliente cliente)
        {
            var resultadoValidacao = validadorCliente.Validate(cliente);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(cliente))
                erros.Add($"Este nome '{cliente.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Cliente cliente)
        {
            Cliente clienteEncontrado = repositorioCliente.SelecionarPorNome(cliente.Nome);

            if (clienteEncontrado != null &&
                clienteEncontrado.Id != cliente.Id &&
                clienteEncontrado.Nome == cliente.Nome)
            {
                return true;
            }

            return false;
        }

    }

}

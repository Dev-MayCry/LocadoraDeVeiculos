﻿using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloTaxaServico {

    public class ServicoTaxaServico {
        IRepositorioTaxaServico repositorioTaxaServico;
        IValidadorTaxaServico validadorTaxaServico;

        public ServicoTaxaServico(IRepositorioTaxaServico repositorioTaxaServico, IValidadorTaxaServico validadorTaxaServico) {
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.validadorTaxaServico = validadorTaxaServico;
        }

        public Result Inserir(TaxaServico taxaServico) {
            Log.Debug($"Tentando inserir taxa...{taxaServico}");

            List<string> erros = ValidarTaxaServico(taxaServico);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioTaxaServico.Inserir(taxaServico);

                Log.Debug($"Taxa {taxaServico.Id} inserida com sucesso");

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir taxa.";

                Log.Error(exc, msgErro + $"{taxaServico}");

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(TaxaServico taxaServico) {
            Log.Debug($"Tentando editar taxa...{taxaServico}");

            List<string> erros = ValidarTaxaServico(taxaServico);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioTaxaServico.Editar(taxaServico);

                Log.Debug($"Taxa {taxaServico.Id} editada com sucesso");

                return Result.Ok();
            } catch (Exception ex) {
                string msgErro;

                //Conferir depois quais bancos utilizam taxa
                if (ex.Message.Contains("FK_TBAluguel_TBTaxaServico"))
                    msgErro = "Esta taxa está relacionada com um aluguel em aberto e não pode ser editada";
                else
                    msgErro = "Falha ao tentar editar taxa";

                Log.Error(ex, msgErro + $"{taxaServico.Id}");

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(TaxaServico taxaServico) {
            Log.Debug($"Tentando excluir taxa...{taxaServico}");

            try {
                bool taxaServicoExiste = repositorioTaxaServico.Existe(taxaServico);

                if (taxaServicoExiste == false) {
                    Log.Warning($"Taxa {taxaServico.Id} não encontrada para excluir");

                    return Result.Fail("Taxa não encontrada");
                }

                repositorioTaxaServico.Excluir(taxaServico);

                Log.Debug($"Taxa {taxaServico.Id} excluída com sucesso");

                return Result.Ok();
            } catch (SqlException ex) {
                List<string> erros = new List<string>();

                string msgErro;

                //Conferir depois quais bancos utilizam taxa
                if (ex.Message.Contains("FK_TBAluguel_TBTaxaServico"))
                    msgErro = "Esta taxa está relacionada com um aluguel em aberto e não pode ser excluída";
                else
                    msgErro = "Falha ao tentar excluir taxa";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + $" {taxaServico.Id}");

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarTaxaServico(TaxaServico taxaServico) {
            var resultadoValidacao = validadorTaxaServico.Validate(taxaServico);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(taxaServico))
                erros.Add($"Este nome '{taxaServico.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(TaxaServico taxaServico) {
            TaxaServico taxaServicoEncontrada = repositorioTaxaServico.SelecionarPorNome(taxaServico.Nome);

            if (taxaServicoEncontrada != null &&
                taxaServicoEncontrada.Id != taxaServico.Id &&
                taxaServicoEncontrada.Nome == taxaServico.Nome) {
                return true;
            }

            return false;
        }

    }
}

﻿
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.Compartilhado;


namespace LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.ModuloParceiro {
    public class RepositorioParceiroOrm : RepositorioBaseORM<Parceiro> , IRepositorioParceiro {
        public RepositorioParceiroOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public Parceiro SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

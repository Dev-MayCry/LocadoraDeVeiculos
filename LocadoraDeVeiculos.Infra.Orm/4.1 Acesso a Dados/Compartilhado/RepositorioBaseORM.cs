﻿using LocadoraDeVeiculos.Dominio.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.Compartilhado {
    public class RepositorioBaseORM<T> : IRepositorio<T> where T : EntidadeBase<T> {

        protected readonly LocadoraDeVeiculosDbContext dbContext;
        protected DbSet<T> registros;

        public RepositorioBaseORM(LocadoraDeVeiculosDbContext dbContext) {
            this.dbContext = dbContext;
            registros = dbContext.Set<T>();
        }
        public void Inserir(T novoRegistro) {
            registros.Add(novoRegistro);

            dbContext.SaveChanges();
        }

        public void Editar(T registro) {
            registros.Update(registro);

            dbContext.SaveChanges();
        }

        public void Excluir(T registro) {
            registros.Remove(registro);

            dbContext.SaveChanges();
        }

        public bool Existe(T registro) {
            return registros.Contains(registro);
        }

        public T SelecionarPorId(int id) {
            return registros.Find(id);
        }

        public List<T> SelecionarTodos() {
            return registros.ToList();
        }
    }
}

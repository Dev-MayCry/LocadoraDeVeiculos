using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel {
    public class RepositorioAluguelOrm : RepositorioBaseORM<Aluguel>, IRepositorioAluguel {
        public RepositorioAluguelOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }

        public List<Aluguel> SelecionarTodos() {
            return registros.Include(x => x.GrupoAutomovel)
                .Include(x => x.Funcionario)
                .Include(x => x.Cliente)
                .Include(x => x.Condutor)
                .Include(x => x.GrupoAutomovel)
                .Include(x => x.Automovel)
                .Include(x => x.PlanoCobranca)
                .Include(x => x.Cupom)
                .ToList();
        }

        public List<Aluguel> SelecionarPorEncerrado() {
            return registros.Where(x => x.Encerrado == true).ToList();
        }

        public Aluguel SelecionarPorAutomovel(Automovel a) {
            return registros.FirstOrDefault(x => x.Automovel == a);
        }
        public Aluguel SelecionarPorCondutor(Condutor c) {
            return registros.FirstOrDefault(x => x.Condutor == c);
        }
    }
}

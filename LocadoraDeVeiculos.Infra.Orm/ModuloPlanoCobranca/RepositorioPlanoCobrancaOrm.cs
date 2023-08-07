using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca {
    public class RepositorioPlanoCobrancaOrm : RepositorioBaseORM<PlanoCobranca>, IRepositorioPlanoCobranca {

        public RepositorioPlanoCobrancaOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext) {
        }
        public PlanoCobranca SelecionarPorNome(string nome) {
            throw new NotImplementedException();
        }

        public List<PlanoCobranca> SelecionarTodos() {
            return registros.Include(x => x.grupo).ToList();


        }

        public List<PlanoCobranca> SelecionarPorGrupo(GrupoAutomovel grupoautomovel) {
            return registros.Where(x => x.grupo == grupoautomovel).ToList();
        }




    }
}

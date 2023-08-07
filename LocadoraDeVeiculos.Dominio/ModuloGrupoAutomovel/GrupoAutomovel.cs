using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{
    public class GrupoAutomovel : EntidadeBase<GrupoAutomovel> {
        
        public string? Nome{ get; set; }

        public bool PossuiPlanoDiario { get; set; } = false;
        public bool PossuiPlanoControlador { get; set; } = false;
        public bool PossuiPlanoLivre { get; set; } = false;

        public GrupoAutomovel() { }
        public GrupoAutomovel(string nome) {
            Nome = nome;
        }
        public GrupoAutomovel(Guid id, string nome) : this(nome){
            Id = id;
        }

        public override void Atualizar(GrupoAutomovel registro) {
            Nome = registro.Nome;
        }

        public override string ToString() {
            return Nome;
        }
        
        public bool IncluirPlano(PlanoCobranca plano) {
            if (plano.tipo == TipoPlanoEnum.PlanoLivre && PossuiPlanoLivre == false) {
                PossuiPlanoLivre = true;
                return true;

            } else if (plano.tipo == TipoPlanoEnum.PlanoControlador && PossuiPlanoControlador == false) {
                PossuiPlanoControlador = true;
                return true;

            } else if (plano.tipo == TipoPlanoEnum.PlanoDiario && PossuiPlanoDiario == false) {
                PossuiPlanoDiario = true;
                return true;

            } else return false;
        }

        public void ExcluirPlano(PlanoCobranca plano) {
            if (plano.tipo == TipoPlanoEnum.PlanoLivre) PossuiPlanoLivre = false;
            else if (plano.tipo == TipoPlanoEnum.PlanoControlador) PossuiPlanoControlador = false;
            else if (plano.tipo == TipoPlanoEnum.PlanoDiario) PossuiPlanoDiario = false;
        }
    }
}

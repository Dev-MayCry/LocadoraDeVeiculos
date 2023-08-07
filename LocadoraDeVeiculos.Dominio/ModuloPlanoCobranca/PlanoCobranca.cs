using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;


namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca {
    public class PlanoCobranca: EntidadeBase<PlanoCobranca> {

        public GrupoAutomovel grupo { get; set; }

        public TipoPlanoEnum tipo { get; set; }
        public decimal PrecoDiaria { get; set; }
        public decimal PrecoKm { get; set; }
        public int KmDisponiveis { get; set; }

        public PlanoCobranca() {

        }

        public PlanoCobranca(GrupoAutomovel grupo, TipoPlanoEnum tipo, decimal precoDiaria, decimal precoKm) {
            this.grupo = grupo;
            this.tipo = tipo;
            PrecoDiaria = precoDiaria;
            PrecoKm = precoKm;
        }

        public PlanoCobranca(GrupoAutomovel grupo, TipoPlanoEnum tipo, decimal precoDiaria, decimal precoKm, int kmDisponiveis) {
            this.grupo = grupo;
            this.tipo = tipo;
            PrecoDiaria = precoDiaria;
            PrecoKm = precoKm;
            KmDisponiveis = kmDisponiveis;
        }

        public PlanoCobranca(GrupoAutomovel grupo, TipoPlanoEnum tipo, decimal precoDiaria) {
            this.grupo = grupo;
            this.tipo = tipo;
            PrecoDiaria = precoDiaria;
        }

        public override void Atualizar(PlanoCobranca registro) {
            throw new NotImplementedException();
        }

        
    }
}

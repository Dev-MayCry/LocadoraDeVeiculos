using LocadoraDeVeiculos.Dominio.Compartilhado;
using System.Runtime.CompilerServices;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{
    public class GrupoAutomovel : EntidadeBase<GrupoAutomovel> {
        
        public string? Nome{ get; set; }

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

        public override string? ToString() {
            return Nome;
        }
    }
}

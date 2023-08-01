using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro {
    public class Parceiro : EntidadeBase<Parceiro> {

        public string Nome { get; set; }

        public Parceiro() { }
        public Parceiro(string Nome) {
            this.Nome = Nome;
        }
        public Parceiro(int id, string nome) : this(nome) {
            Id = id;
        }

        public override void Atualizar(Parceiro registro) {
            Nome = registro.Nome;
        } 
    }
}

﻿

using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro {
    public class Parceiro : EntidadeBase<Parceiro> 
    {
        public override void Atualizar(Parceiro registro) {
            Nome = registro.Nome;
        }
        public Parceiro() {

        }

        public Parceiro(int id, string nome) : this(nome) {
            Id = id;
        }
        public string Nome { get; set; }

        public Parceiro(string Nome) {
            this.Nome = Nome;
        }
        public override string ToString()
        {
            return Nome;
        }
     
    }
}

using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {

        public string Nome { get; set; }

        public Cliente() { }
        public Cliente(string Nome) : this()
        {
            this.Nome = Nome;
        }
        public Cliente(Guid id, string nome) : this(nome)
        {
            Id = id;
        }

        public override void Atualizar(Cliente registro)
        {
            Nome = registro.Nome;
        }

    }
}

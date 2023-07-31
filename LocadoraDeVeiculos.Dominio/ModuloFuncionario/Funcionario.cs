using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario {
    public class Funcionario: EntidadeBase<Funcionario> {

        
        public override void Atualizar(Funcionario registro) {
                Nome = registro.Nome;
            }
        public Funcionario() {

            }

        public Funcionario(int id, string nome) : this(nome) {
                Id = id;
            }
        public string Nome { get; set; }

        public DateTime DataAdmissao { get; set; }

        public float Salario { get; set; }

        public Funcionario(string Nome) {
                this.Nome = Nome;
            }


        
    }
}

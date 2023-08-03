using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel {
    public class Automovel : EntidadeBase<Automovel>{
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public TipoCombustivelEnum TipoCombustivel { get; set; }
        public int CapacidadeLitros { get; set; }
        public decimal Ano { get; set; }
        public byte[] Foto { get; set; }
        public GrupoAutomovel GrupoAutomovel { get; set; }

        public Automovel() {}

        public Automovel(string placa, string modelo, string marca, string cor, TipoCombustivelEnum tipoCombustivel, int capacidadeLitros, decimal ano, GrupoAutomovel grupoAutomovel) {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            TipoCombustivel = tipoCombustivel;
            CapacidadeLitros = capacidadeLitros;
            Ano = ano;
            GrupoAutomovel = grupoAutomovel;
        }

        public Automovel(string placa, string modelo, string marca, string cor, TipoCombustivelEnum tipoCombustivel, int capacidadeLitros, decimal ano, byte[] foto, GrupoAutomovel grupoAutomovel) {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            TipoCombustivel = tipoCombustivel;
            CapacidadeLitros = capacidadeLitros;
            Ano = ano;
            Foto = foto;
            GrupoAutomovel = grupoAutomovel;
        }

        public override void Atualizar(Automovel registro) {
            Placa = registro.Placa;
            Modelo = registro.Modelo;
            Marca = registro.Marca;
            Cor = registro.Cor;
            TipoCombustivel = registro.TipoCombustivel;
            CapacidadeLitros = registro.CapacidadeLitros;
            Ano = registro.Ano;
            GrupoAutomovel = registro.GrupoAutomovel;
        }

        public override string ToString() {
            return Modelo +" "+ Cor +" "+ Placa +" "+ Ano;
        }
    }
}
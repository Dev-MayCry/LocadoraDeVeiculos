using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro {
    public interface IRepositorioParceiro: IRepositorio<Parceiro> {
        void Inserir(Cliente cliente);
        Parceiro SelecionarPorNome(string nome);
    }
}

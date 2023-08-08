using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor {
    public interface IRepositorioCondutor : IRepositorio<Condutor> {
        Condutor SelecionarPorNome(string nome);

        List<Condutor> SelecionarTodos();
    }
}

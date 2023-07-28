using LocadoraDeVeiculos.Dominio.Compartilhado;


namespace LocadoraDeVeiculos.Dominio.ModuloParceiro {
    public interface IRepositorioParceiro: IRepositorio<Parceiro> {

        Parceiro SelecionarPorNome(string nome);

        
    }
}

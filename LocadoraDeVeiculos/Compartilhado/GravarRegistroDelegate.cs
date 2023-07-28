using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;


namespace LocadoraDeVeiculos.WinApp.Compartilhado {

    public delegate Result GravarRegistroDelegate<TEntidade>(TEntidade registro)
        where TEntidade : EntidadeBase<TEntidade>;

}

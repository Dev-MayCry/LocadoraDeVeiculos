﻿using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public interface IRepositorioCliente : IRepositorio<Cliente>
    {
        Cliente SelecionarPorNome(string nome);
    }
}

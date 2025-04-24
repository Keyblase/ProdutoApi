using ProdutoApi.Models;
using System.Collections.Generic;

namespace ProdutoApi.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterTodos();
        Produto ObterPorId(int id);
        IEnumerable<Produto> ObterPorNome(string nome);
        void Adicionar(Produto produto);
        void Remover(int id);
        long Contar();
    }
}
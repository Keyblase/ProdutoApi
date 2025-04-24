using ProdutoApi.Models;
using ProdutoApi.Repositories;

namespace ProdutoApi.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Produto> ListarTodos() => _repository.ObterTodos();
        public Produto BuscarPorId(int id) => _repository.ObterPorId(id);
        public IEnumerable<Produto> BuscarPorNome(string nome) => _repository.ObterPorNome(nome);
        public void Cadastrar(Produto produto) => _repository.Adicionar(produto);
        public void Deletar(int id) => _repository.Remover(id);
        public long ContarProdutos() => _repository.Contar();
    }
}
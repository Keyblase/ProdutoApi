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
        public void Atualizar(Produto produto)
        {
            var produtoExistente = BuscarPorId(produto.Id);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Preco = produto.Preco;
                // Se tiver mais propriedades, atualize aqui também

                _repository.Update(produtoExistente);
                _repository.SaveChanges();
            }
        }
        public void SaveChanges()
        {
            _repository.SaveChanges(); 
        }
    }
}
using ProdutoApi.Data;
using ProdutoApi.Models;
using ProdutoApi.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Produto> ObterTodos() => _context.Produtos.ToList();
    public Produto ObterPorId(int id) => _context.Produtos.Find(id);
    public IEnumerable<Produto> ObterPorNome(string nome) =>
        _context.Produtos.Where(p => p.Nome.Contains(nome)).ToList();
    public void Adicionar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }
    public void Remover(int id)
    {
        var produto = ObterPorId(id);
        if (produto != null)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
    public long Contar() => _context.Produtos.LongCount();

    public void Update(Produto produto)
    {
        _context.Produtos.Update(produto);
        _context.SaveChanges();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

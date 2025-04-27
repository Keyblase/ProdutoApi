using Microsoft.AspNetCore.Mvc;
using ProdutoApi.Models;
using ProdutoApi.Services;

namespace ProdutoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController(ProdutoService service) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(service.ListarTodos());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = service.BuscarPorId(id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpGet("buscar/{nome}")]
        public IActionResult BuscarPorNome(string nome) =>
            Ok(service.BuscarPorNome(nome));

        [HttpGet("contar")]
        public IActionResult Contar() => Ok(service.ContarProdutos());

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            service.Cadastrar(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.Deletar(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            var produtoExistente = service.BuscarPorId(id);
            if (produtoExistente == null) return NotFound();

            produto.Id = id; // Garante que o ID da rota é usado
            service.Atualizar(produto);
            return NoContent();
        }
    }
}
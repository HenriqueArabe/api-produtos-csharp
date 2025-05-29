using Microsoft.AspNetCore.Mvc;
using API_Produtos.Models;
using API_Produtos.Data;

namespace API_Produtos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return ProdutoRepository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = ProdutoRepository.Get(id);
            if (produto == null)
                return NotFound();
            return produto;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            ProdutoRepository.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
                return BadRequest();
            var existing = ProdutoRepository.Get(id);
            if (existing == null)
                return NotFound();

            ProdutoRepository.Update(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = ProdutoRepository.Get(id);
            if (existing == null)
                return NotFound();

            ProdutoRepository.Delete(id);
            return NoContent();
        }
    }
}

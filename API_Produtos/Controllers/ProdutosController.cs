using Microsoft.AspNetCore.Mvc;
using API_Produtos.Models;
using API_Produtos.Data;

namespace API_Produtos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        // GET: api/produtos
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return ProdutoRepository.GetAll();
        }

        // GET: api/produtos/1
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = ProdutoRepository.Get(id);
            if (produto == null)
                return NotFound();
            return produto;
        }

        // POST: api/produtos
        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            ProdutoRepository.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        // PUT: api/produtos/1
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

        // DELETE: api/produtos/1
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

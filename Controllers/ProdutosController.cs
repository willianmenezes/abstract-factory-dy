using AbstractFactory.Clients;
using AbstractFactory.Domain.ValueObj;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet("Alimentos")]
        public IActionResult BuscarAlimentos([FromQuery] TipoProduto tipoProduto)
        {
            var produtoClient = ProdutoClient.CriarProdutoFactory(tipoProduto);

            var alimentos = produtoClient.BuscarAlimentos();

            if (alimentos.Count == 0)
            {
                return BadRequest();
            }

            return Ok(alimentos);
        }

        [HttpGet("Embalagens")]
        public IActionResult BuscarEmbalagens([FromQuery] TipoProduto tipoProduto)
        {
            var produtoClient = ProdutoClient.CriarProdutoFactory(tipoProduto);

            var alimentos = produtoClient.BuscarEmbalagens();

            if (alimentos.Count == 0)
            {
                return BadRequest();
            }

            return Ok(alimentos);
        }
    }
}

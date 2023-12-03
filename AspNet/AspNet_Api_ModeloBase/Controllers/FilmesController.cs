using AspNet_Api_ModeloBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Api_ModeloBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);

            return CreatedAtAction(nameof(ObterFilme),
                    new { id = filme.Id },
                    filme);

            //Postman teste, body (raw)
            //https://localhost:7106/Filmes
            //{
            //    "Titulo" : "The Matrix",
            //    "Genero" : "Ação"
            //}
        }

        [HttpGet]
        public IEnumerable<Filme> ObterFilmes(int skip = 0, int take = 50)
        {
            return filmes.Skip(skip).Take(take);

            //Postman exemplo de url: https://localhost:7106/Filmes?skip=0&take=10
            //Postman exemplo de url: https://localhost:7106/Filmes?take=10
        }

        [HttpGet("{id}")]
        public IActionResult ObterFilme(int id)
        {
            var filme = filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null) 
                return NotFound();

            return Ok(filme);

            //Postman exemplo de url: https://localhost:7106/Filmes/2
            //id seria o valor após Filmes/  
            //no exemplo da url o id passado na requisicao é o 2
        }
    }
}

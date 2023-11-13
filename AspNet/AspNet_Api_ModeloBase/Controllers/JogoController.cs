using AspNet_Api_ModeloBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Api_ModeloBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        private static List<Jogo> jogos = new List<Jogo>();

        [HttpPost]
        public void AdicionarJogo([FromBody] Jogo jogo)
        {
            jogos.Add(jogo);
            Console.WriteLine(jogo.Titulo);
            Console.WriteLine(jogo.Genero);
        }

        [HttpGet]
        public Jogo ObterJogo([FromBody] Jogo jogo)
        {
            var jogoEncontrado = jogos.Find(j => j.Titulo == jogo.Titulo);

            if (jogoEncontrado != null)
                return jogoEncontrado;
            else
                return new Jogo();
        }
    }
}

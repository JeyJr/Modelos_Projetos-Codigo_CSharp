using AspNet_Api_ModeloBase.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNet_Api_ModeloBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosDigitaisController : ControllerBase
    {
        private static List<Jogo> jogos = new List<Jogo>();
        private static int id = 0;

        //Exemplo basico dos metodos Get e Post
        [HttpPost]
        public void AdicionarJogo([FromBody] Jogo jogo)
        {
            jogo.Id = id++;

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

        [HttpGet("{id}")]
        public Jogo? ObterJogo(int id)
        {
            return jogos.FirstOrDefault(jogos => jogos.Id == id);
        }
    }
}

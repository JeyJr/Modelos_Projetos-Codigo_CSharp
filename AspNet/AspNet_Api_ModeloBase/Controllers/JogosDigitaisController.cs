using AspNet_Api_ModeloBase.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNet_Api_ModeloBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosDigitaisController : ControllerBase
    {
        private static List<Jogo> jogos = new List<Jogo>();

        [HttpPost]
        public void AdicionarJogo([FromBody] Jogo jogo)
        {
            try
            {
                if (jogo == null)
                    throw new Exception("Objeto nulo inválido!");

                if (jogo.Titulo.Length > 100 || jogo.Titulo.Length <= 0)
                    throw new Exception("Título inválido!");

                if (jogo.Genero.Length > 50 || jogo.Genero.Length <= 0)
                    throw new Exception("Gênero inválido!");

                jogos.Add(jogo);
                Console.WriteLine(jogo.Titulo);
                Console.WriteLine(jogo.Genero);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public Jogo ObterJogo([FromBody] Jogo jogo)
        {
            try
            {
                var jogoEncontrado = jogos.Find(j => j.Titulo == jogo.Titulo);

                if (jogoEncontrado != null)
                    return jogoEncontrado;
                else
                    throw new Exception("Jogo não encontrado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

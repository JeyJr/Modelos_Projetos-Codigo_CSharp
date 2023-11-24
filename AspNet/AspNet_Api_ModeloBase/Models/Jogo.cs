using System.ComponentModel.DataAnnotations;

namespace AspNet_Api_ModeloBase.Models
{
    public class Jogo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [MaxLength(100, ErrorMessage = "Título não pode ultrapassar limite de 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [MaxLength(50, ErrorMessage = "Gênero não pode ultrapassar limite de 50 caracteres")]
        public string Genero { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace API_ModeloSimples.Modelos
{
    public class Musica
    {
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
    }
}

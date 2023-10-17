using API_ModeloSimples.Modelos;
using System.Data;
using System.Text.Json;

namespace API_ModeloSimples
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private string endPoint = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";


        public async Task ObterMusicasExemplo_01()
        {
            using (var client = new HttpClient())
            {
                var resposta = await client.GetStringAsync(endPoint);

                #region Exemplo de resultado
                //exemplo de resultado em tipo string

                /*
                             {
                    "artist": "The Chainsmokers",
                    "song": "#SELFIE - Original Mix",
                    "duration_ms": 183750,
                    "explicit": "False",
                    "year": "2014",
                    "popularity": "0",
                    "danceability": "0.789",
                    "energy": "0.915",
                    "key": 0,
                    "loudness": "-3.263",
                    "mode": "1",
                    "speechiness": "0.248",
                    "acousticness": "0.0135",
                    "instrumentalness": "8.77e-06",
                    "liveness": "0.0818",
                    "valence": "0.66",
                    "tempo": "127.955",
                    "genre": "pop, Dance/Electronic"
                },
                {
                    "artist": "will.i.am",
                    "song": "#thatPOWER",
                    "duration_ms": 279506,
                    "explicit": "False",
                    "year": "2013",
                    "popularity": "68",
                    "danceability": "0.797",
                    "energy": "0.608",
                    "key": 6,
                    "loudness": "-6.096",
                    "mode": "0",
                    "speechiness": "0.0584",
                    "acousticness": "0.00112",
                    "instrumentalness": "7.66e-05",
                    "liveness": "0.0748",
                    "valence": "0.402",
                    "tempo": "127.999",
                    "genre": "hip hop, pop"
                },
                 */
                #endregion
            }
        }

        IEnumerable<Musica> musicasColecao;
        public async Task ObterMusicasExemplo_02()
        {
            using (var client = new HttpClient())
            {
                var resposta = await client.GetStringAsync(endPoint);
                musicasColecao = JsonSerializer.Deserialize<List<Musica>>(resposta).ToList();

                // Use Invoke para atualizar a interface do usuário na thread da interface
                Invoke(new Action(() => AtualizarDataGridViewLINQ()));
            }
        }
        private void AtualizarDataGridViewAddLinhas()
        {
            foreach (var musica in musicasColecao)
            {
                int rowIndex = dtgMusica.Rows.Add();
                dtgMusica.Rows[rowIndex].Cells["Nome"].Value = musica.Nome;
                dtgMusica.Rows[rowIndex].Cells["Artista"].Value = musica.Artista;
                dtgMusica.Rows[rowIndex].Cells["Duracao"].Value = musica.Duracao;
                dtgMusica.Rows[rowIndex].Cells["Genero"].Value = musica.Genero;
            }
        }
        private void AtualizarDataGridViewLINQ()
        {
            var musicas = musicasColecao.Select(s => new
            {
                Nome = s.Nome,
                Artista = s.Artista,
                Genero = s.Genero,
                Duracao = s.Duracao
            })
                .ToList();

            dtgMusica.DataSource = musicas;
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Task.Run(() => ObterMusicasExemplo_02());
        }
    }
}
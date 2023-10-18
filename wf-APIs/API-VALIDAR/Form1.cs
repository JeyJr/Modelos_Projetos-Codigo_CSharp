using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace API_VALIDAR
{
    public partial class Form1 : Form
    {
        public string RedirectUri { get; } = "http://127.0.0.1:8080/assinar.php";
        public string ClientId { get; } = "devLocal";
        public string ClientSecret { get; } = "younIrtyij3";
        public string OauthServer { get; } = "https://cas.staging.iti.br/oauth2.0"; 
        public string ApiServer { get; } = "https://assinatura-api.staging.iti.br/externo/v2"; 
        public string TokenUri => $"{OauthServer}/token";
        public string CertificateUri => $"{ApiServer}/certificadoPublico";
        public string SigningUri => $"{ApiServer}/assinarPKCS7";
        

        private string hash = "";
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
        }

        public static string CalculateSHA256Hash(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                using (var sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }

        private static HttpClient client = new HttpClient();

        public async Task<string> PostHashToApi()
        {
            try
            {
                var data = new { hash = this.hash }; // Substitua 'hash' pelo nome do campo que a API espera

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                //var response = await client.PostAsync(ApiServer, content);
                var response = await client.PostAsync(SigningUri, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    return null; // Lida com erros de acordo com as respostas da API
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um arquivo",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "pdf", // Extensão padrão (opcional)
                Filter = "Arquivos PDF|*.pdf", // Filtre os tipos de arquivo (opcional)
                FilterIndex = 1, // Define o tipo de filtro como padrão (opcional)
                Multiselect = false, // Permite selecionar apenas um arquivo (opcional)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                hash = CalculateSHA256Hash(Path.GetFullPath(selectedFilePath));
            }

            Task.Run(() => PostHashToApi());
        }
    }
}
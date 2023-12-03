using System.Net.Http.Headers;

namespace API_BRY_ValidacaoAssinaturaDigital
{
    public partial class FrmPrincipal : Form
    {
        //Link teste da API: https://fw2.bry.com.br/api/pdf-verification-service/swagger-ui/index.html#/
        //Exemplo codigo: https://gitlab.com/brytecnologia-team/integracao/api-assinatura
        //Documentação ref: https://api-assinatura.bry.com.br/api-assinatura-digital#servico-de-verificacao-pdf
        string caminhoDoArquivo = "";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCarregarArquivo_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                caminhoDoArquivo = openFileDialog.FileName;
                Task.Run(() => Inicializar());
            }
        }

        private async Task Inicializar() 
        {
            // URL da API
            string apiUrl = "https://fw2.bry.com.br/api/pdf-verification-service/v1/signatures/verify";

            // Token de Autorização - Preciso renovar sempre o token
            string authToken = "eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJFTjI1UTRjTnZEYW1XSjFuUUVIdmhzN1k0VDZEZlhxQnNGZ0N0WVBHS2Y4In0.eyJleHAiOjE2OTc3NjY3ODUsImlhdCI6MTY5Nzc2NDk4NSwianRpIjoiNmIwN2M1ZGQtN2E5Ni00ODQ4LWJkZWEtOGMxNTFkN2MzMmYxIiwiaXNzIjoiaHR0cHM6Ly9jbG91ZC5icnkuY29tLmJyL2F1dGgvcmVhbG1zL2Nsb3VkIiwiYXVkIjoiYWNjb3VudCIsInN1YiI6ImY6ZWExZDg2NGYtNzg3MS00M2Q2LWJjYmYtMTE4N2M3ZmI4MTg2OmpleWpyIiwidHlwIjoiQmVhcmVyIiwiYXpwIjoidGVyY2Vpcm9zIiwic2Vzc2lvbl9zdGF0ZSI6Ijk2OGNmNjRlLWJhYzYtNGU5MS05Y2E3LWFiODBkZjhjYjFjNSIsImFjciI6IjEiLCJyZWFsbV9hY2Nlc3MiOnsicm9sZXMiOlsib2ZmbGluZV9hY2Nlc3MiLCJ1c3VhcmlvIiwidW1hX2F1dGhvcml6YXRpb24iLCJ1c2VyIl19LCJyZXNvdXJjZV9hY2Nlc3MiOnsiYWNjb3VudCI6eyJyb2xlcyI6WyJtYW5hZ2UtYWNjb3VudCIsIm1hbmFnZS1hY2NvdW50LWxpbmtzIiwidmlldy1wcm9maWxlIl19fSwic2NvcGUiOiJwcm9maWxlIGVtYWlsIiwiY29kZSI6IjM2NjMzNzk3ODc3IiwiY2xvdWRfYXBwX2tleSI6ImFwcC5qZXlqci4xNjk3NzY0OTE0NDIyIiwiZW1haWxfdmVyaWZpZWQiOmZhbHNlLCJuYW1lIjoiSm9zw6kgQW50w7RuaW8gRWxpYXMgZGEgU2lsdmEgSnVuaW9yIiwiY2xvdWRfdG9rZW4iOiJKeHFpUjRtN3dOYTM2MGNXV0hVRDc3eXVuZ2lyYlpydDIxWHA4WXNEM1phcnFycUxQWlp4QWdGVE1EQzBwT2dVIiwicHJlZmVycmVkX3VzZXJuYW1lIjoiamV5anIiLCJnaXZlbl9uYW1lIjoiSm9zw6kiLCJmYW1pbHlfbmFtZSI6IkFudMO0bmlvIEVsaWFzIGRhIFNpbHZhIEp1bmlvciJ9.NryGRjkhWoihQie637wnFoyTU-0EEWIYWyTnEuWsnz_Nk_fd_-kCUFmCOSL7h-jdYaCi5jsURZ1QgeFTA9DoCY17odomFJxG0se9GI26cQUBaGjInk4R223LzPvqtIuoA1wIBGIEzFxtDOUgJZ0EBla2GiFYOvgDvattgedtJaTPMQSSN7zh7SveAaFExBpIVMXctx5v884IA4jKJQYR__IQUi3-3bmoQHqSVxuyr9hYIAYLNu8teoxy6-o3jxE3IAV6BsBN7aj_YhGOozxYQK8ObatnRlTcBsODx5_wyXZbWFw9VqzdBHtWDVlWSibjEM0IlaVsMf5kHVD7M0f29g";

            // Criar um cliente HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Definir o cabeçalho "Authorization" com o token
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                
                // Construir o conteúdo da solicitação
                MultipartFormDataContent content = new MultipartFormDataContent();

                // Adicionar o arquivo PDF
                byte[] fileBytes = File.ReadAllBytes(caminhoDoArquivo);
                ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "signatures[0][content]",
                    FileName = "TesteGovbr.pdf"
                };
                content.Add(fileContent);

                // Adicionar o nonce da assinatura
                content.Add(new StringContent("251"), "signatures[0][nonce]");

                // Configurar "contentsReturn" e "nonce" da requisição
                content.Add(new StringContent("true"), "contentsReturn");
                content.Add(new StringContent("2176"), "nonce");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Erro na solicitação. Status: {response.StatusCode}");
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Conteúdo do erro: " + errorContent);
                }
            }
        }
    }
}
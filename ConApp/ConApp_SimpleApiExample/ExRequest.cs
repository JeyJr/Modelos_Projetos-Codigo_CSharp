using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_SimpleApiExample
{
    public class ExRequest
    {
        public async void RequestDocumento()
        {
            string requestURL = "https://enderecodaapi";
            string accessToken = "token de login ou acesso";
            string documentID = "id do documento que sera pesquisado na api";

            string authorization = $"Bearer {accessToken}";

            using (HttpClient client = new HttpClient())
            {
                //Add varios parametros no header
                client.DefaultRequestHeaders.Add("Authorization", authorization);
                client.DefaultRequestHeaders.Add("api key", accessToken);

                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{requestURL}{documentID}");
                    response.EnsureSuccessStatusCode();

                    string responseString = await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}

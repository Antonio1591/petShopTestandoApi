using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Services
{
    public class ApiClient<T>
    {
        private readonly HttpClient client;

        public ApiClient(HttpClient client)
        {
            this.client = client;
            client.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<IEnumerable<T>> getAsync(string url)
        {
            var response = await client.GetAsync(url);
            var context = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(context).ToList();
        }
        public async Task<T>  Create(string url, T imput)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonContent = JsonConvert.SerializeObject(imput);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync(url, contentString);

            return imput ;
        }

   

        //HttpResponseMessage responsePost = await client.PostAsync("Pessoa/Resultado", contentString);
    }
}

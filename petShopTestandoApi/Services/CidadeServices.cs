using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace petShopTestandoApi.Services
{
    [Authorize]
    [Route("https://localhost:5001/api/pessoa")]
    public class CidadeServices : ICidadeServices
    {
        ApiClient<Cidade> _apiClient = new ApiClient<Cidade>(new HttpClient());

        public async Task<IEnumerable<Cidade>> RetornarCidades()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:5001/api/");
            //var response = await client.GetAsync("Cidade");
            //var context = await response.Content.ReadAsStringAsync();
            //var cidades = JsonConvert.DeserializeObject<List<Cidade>>(context).ToList();
            //return cidades;
            return await _apiClient.getAsync("Cidade") ;
        }

        public async Task retornaCidade(string nome)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync($"Cidade/Nome/{nome}");
            var context = await response.Content.ReadAsStringAsync();
            var pessoas = JsonConvert.DeserializeObject<Cidade>(context);
        }

        public async Task<CidadeViewModel> CreateCidade(CidadeInputModel Input)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:5001/api/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var jsonContent = JsonConvert.SerializeObject(cidade);
            //var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            //contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            //HttpResponseMessage responsePost = await client.PostAsync("Cidade/Resultado", contentString);
            var cidade = new Cidade(Input.Nome, Input.UF);
            //MessageBox.Show(jsonContent);
           await _apiClient.Create("Cidade/Resultado",cidade);
            return cidade.ParaViewModel();
        }
    }
}

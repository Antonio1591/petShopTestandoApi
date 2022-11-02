using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace petShopTestandoApi.Services
{
    [Authorize]
    [Route("https://localhost:5001/api/pessoa")]
    public class CidadeServices : ICidadeServices
    {
        public async Task<IEnumerable<Cidade>> RetornarCidades()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync("Cidade");
            var context = await response.Content.ReadAsStringAsync();
            var cidades = JsonConvert.DeserializeObject<List<Cidade>>(context).ToList();
            return cidades;
        }

        public async Task retornaCidade(string nome)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync($"Cidade/Nome/{nome}");
            var context = await response.Content.ReadAsStringAsync();
            var pessoas = JsonConvert.DeserializeObject<Cidade>(context);
        }
    }
}

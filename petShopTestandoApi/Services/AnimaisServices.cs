using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Model.Input;
using petShopTestandoApi.Model.Mapping;
using petShopTestandoApi.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace petShopTestandoApi.Services
{
    [Authorize]
    [Route("https://localhost:5001/api/pessoa")]
    public class AnimaisServices:IAnimaisServices
    {
        public async Task<IEnumerable<AnimaisViewModel>> retornarAnimais()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync("Animais");
            var context = await response.Content.ReadAsStringAsync();
            var animais = JsonConvert.DeserializeObject<List<AnimaisViewModel>>(context).ToList();

               return animais;
        }

        public async Task<AnimaisViewModel> postAnimal(AnimaisInputModel imput)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var animal = new Animais(imput.Raca, imput.Nome, imput.Responsavel, imput.Situacao);

            var jsonContent = JsonConvert.SerializeObject(animal);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync("Animais/Resultado", contentString);
            MessageBox.Show(jsonContent);
            return animal.ParaViewModel();
        }

    }
}

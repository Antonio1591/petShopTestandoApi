﻿using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace petShopTestandoApi.Services
{
    [Authorize]
    [Route("https://localhost:5001/api/pessoa")]
    public class PessoasServices : IPessoaServices
    {
        CidadeServices _cidadeServices = new CidadeServices();

        private List<Pessoa> _Pessoa;
        public async Task<IEnumerable<PessoaViewModel>> retornaAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync("Pessoa");
            var context = await response.Content.ReadAsStringAsync();

            var pessoas = JsonConvert.DeserializeObject<List<PessoaViewModel>>(context).ToList();
            return pessoas;
        }

        public async Task<PessoaViewModel> Create(PessoaInputModel imput)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var pessoa = new Pessoa(imput.Nome, imput.Cidade, imput.DataNascimento);
            List<Pessoa> Pessoa = new List<Pessoa>();
            Pessoa.Add(pessoa);
            var jsonContent = JsonConvert.SerializeObject(pessoa);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync("Pessoa/Resultado", contentString);


            MessageBox.Show(jsonContent);
            return pessoa.ParaViewModel();
        }
        public async Task<IEnumerable<Pessoa>> RetornaPessoa()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync("Pessoa/Busca");
            var context = await response.Content.ReadAsStringAsync();
            var pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(context).ToList();
            return pessoas;
        }
    }
}

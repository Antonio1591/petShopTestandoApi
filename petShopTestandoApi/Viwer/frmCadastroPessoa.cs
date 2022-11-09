using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Services;

namespace petShopTestandoApi.Viwer
{
    public partial class frmCadastroPessoa : Form
    {
        private IEnumerable<Cidade> _cidades;

        ApiClient<PessoaInputModel> _apiClientePessoa = new ApiClient<PessoaInputModel>(new HttpClient());
        PessoasServices pessoasServices = new PessoasServices();
        ApiClient<Cidade> _apiClient = new ApiClient<Cidade>(new HttpClient());
        //readonly IPessoaServices pessoasServices;
        CidadeServices _cidadeService = new CidadeServices();

        public frmCadastroPessoa()
        {
            InitializeComponent();
        }

        private async void btnCadastra_Click(object sender, EventArgs e)
        {
            var cidade = _cidades.FirstOrDefault(c => c.Nome == cmbCidade.Text);
            var cliente = new PessoaInputModel(txtNome.Text, cidade, dtNascimento.Value);
            

            await pessoasServices.Create(cliente);

            //await _apiClientePessoa.Create("Pessoa/Resultado", cliente);
            if ( MessageBox.Show("Usuario Cadastrado", "Cadastro Usuario", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private async void frmCadastroPessoa_LoadAsync(object sender, EventArgs e)
        {

            //_cidades = await _cidadeService.RetornarCidades();
            _cidades = await _apiClient.getAsync("Cidade");
            foreach (var Cidades in _cidades)
            {
                cmbCidade.Items.Add(Cidades.Nome);
            }
        }
    }
}

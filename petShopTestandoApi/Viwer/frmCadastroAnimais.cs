using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Model.Input;
using petShopTestandoApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petShopTestandoApi.Viwer
{
    public partial class frmCadastroAnimais : Form
    {
        private IEnumerable<PessoaViewModel> _pessoas;
        private IEnumerable<Cliente> _pessoasModel;
        AnimaisServices _animaisServices = new AnimaisServices();
        PessoasServices _pessoasServices = new PessoasServices();
        public frmCadastroAnimais()
        {
            InitializeComponent();
        }

        //public frmCadastroAnimais(IAnimaisServices animaisServices)
        //{
        //    _animaisServices = animaisServices;
        //}

        private async void btnCadastra_Click(object sender, EventArgs e)
        {
            var pessoa = _pessoasModel.FirstOrDefault(p=>p.Nome== cmbResponsvel.Text);
            var result = new AnimaisInputModel(txtRaca.Text, txtNome.Text, pessoa, cmbSituacao.Text);
            await _animaisServices.postAnimal(result);
        }

        private async void frmCadastroAnimais_Load(object sender, EventArgs e)
        {

            _pessoasModel = await _pessoasServices.RetornaPessoa();
            _pessoas = await _pessoasServices.retornaAsync();
            foreach (var Responsavel in _pessoas)
            {
                cmbResponsvel.Items.Add(Responsavel.Nome);
            }
        }
    }
}

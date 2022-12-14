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
    public partial class frmCadastroCidade : Form
    {
        CidadeServices _cidadeServices= new CidadeServices();
        public frmCadastroCidade()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUF.Text == "") return;

            var cidade = new CidadeInputModel(txtNome.Text,txtUF.Text);
           await _cidadeServices.CreateCidade(cidade);
           if (MessageBox.Show("Cidade Cadastrado", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}

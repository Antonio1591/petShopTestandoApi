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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa cadastroPessoa = new frmCadastroPessoa();
            cadastroPessoa.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCadastroAnimais frmCadastroAnimais = new frmCadastroAnimais();
            frmCadastroAnimais.Show();
        }
    }
}

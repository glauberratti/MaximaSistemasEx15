using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio15
{
    public partial class FrmCadFilial : Form
    {
        public FrmCadFilial()
        {
            InitializeComponent();
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            Filial f = new Filial(txtNome.Text, txtCnpj.Text);
            string resultado = ValidaCampos();
            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show(resultado);
                return;
            }
            GerFilial.Gravar(f);
            limparTela();
        }
        private void limparTela()
        {
            txtCnpj.Text = "";
            txtNome.Text = "";
        }

        private string ValidaCampos()
        {
            string resultado = "";

            if (string.IsNullOrEmpty(txtCnpj.Text))
            {
                resultado = "O CNPJ não pode ser vazio.";
            }

            if (!double.TryParse(txtCnpj.Text, out double n))
            {
                resultado = "O CNPJ deve conter apenas números.";
            }

            if (txtCnpj.TextLength != 14)
            {
                //resultado = "O CNPJ deve conter 14 números.";
            }


            if (string.IsNullOrEmpty(txtNome.Text))
            {
                resultado = "O nome não pode ser vazio.";
            }

            return resultado;
        }
    }
}

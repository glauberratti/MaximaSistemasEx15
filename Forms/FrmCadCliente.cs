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
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            byte tipoPes;
            if (radFis.Checked)
            {
                tipoPes = Utils.TipoPessoaFisica;
            }
            else
            {
                tipoPes = Utils.TipoPessoaJuridica;
            }
            Pessoa p = new Pessoa(txtNome.Text, tipoPes, txtNumDoc.Text, txtTel.Text);
            string resultado = ValidaCampos();
            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show(resultado);
                return;
            }
            GerPessoa.Gravar(p);
            limparTela();
        }
        private void limparTela()
        {
            txtNome.Text = "";
            txtNumDoc.Text = "";
            txtTel.Text = "";
        }

        private string ValidaCampos()
        {
            string resultado = "";

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                resultado = "O nome não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(txtNumDoc.Text))
            {
                resultado = "A documento não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(txtTel.Text))
            {
                resultado = "O telefone não pode ser vazio.";
            }

            if (!long.TryParse(txtTel.Text, out long n))
            {
                resultado = "O telefone deve ser numerico.";
            }

            return resultado;
        }
    }
}

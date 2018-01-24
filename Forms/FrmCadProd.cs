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
    public partial class FrmCadProd : Form
    {
        public FrmCadProd()
        {
            InitializeComponent();
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(txtCodigo.Text, txtEmb.Text, double.Parse(txtPreco.Text));
            string resultado = ValidaCampos();
            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show(resultado);
                return;
            }
            GerProduto.Gravar(p);
            limparTela();
        }

        private void limparTela()
        {
            txtCodigo.Text = "";
            txtEmb.Text = "";
            txtPreco.Text = "";
        }

        private string ValidaCampos()
        {
            string resultado = "";

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                resultado = "O código não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(txtEmb.Text))
            {
                resultado = "A embalagem não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                resultado = "O preço não pode ser vazio.";
            }

            if (!double.TryParse(txtPreco.Text, out double n))
            {
                resultado = "O preço deve ser numerico.";
            }

            return resultado;
        }
    }
}

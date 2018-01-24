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
    public partial class FrmForcaDeVendas : Form
    {
        public FrmForcaDeVendas()
        {
            InitializeComponent();
        }

        private void butCadCliente_Click(object sender, EventArgs e)
        {
            FrmCadCliente form = new FrmCadCliente();
            form.Show();
        }

        private void butCadProd_Click(object sender, EventArgs e)
        {
            FrmCadProd form = new FrmCadProd();
            form.Show();
        }

        private void butCadFilial_Click(object sender, EventArgs e)
        {
            FrmCadFilial form = new FrmCadFilial();
            form.Show();
        }

        private void comboProd_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GerProduto.ConsultarDataTable();
            comboProd.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboProd.Items.Add(dt.Rows[i]["Codigo"]);
            }
        }

        private void comboFilial_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GerFilial.ConsultarDataTable();
            comboFilial.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboFilial.Items.Add(dt.Rows[i]["Cnpj"]);
            }
        }

        private void comboClientePedido_DropDown(object sender, EventArgs e)
        {
            comboCliente.Items.Clear();

            DataTable dt = new DataTable();
            dt = GerPessoa.ConsultarDataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboCliente.Items.Add(dt.Rows[i]["NumDocumento"]);
            }
        }

        private void butPedido_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido(comboFilial.Text, comboProd.Text, comboCliente.Text);
            string resultado = ValidaCampos();
            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show(resultado);
                return;
            }
            GerPedido.Gravar(p);
            LimparTela();
        }

        private string ValidaCampos()
        {
            string resultado = "";

            if (string.IsNullOrEmpty(comboFilial.Text))
            {
                resultado = "A filial não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(comboProd.Text))
            {
                resultado = "O produto não pode ser vazio.";
            }

            if (string.IsNullOrEmpty(comboCliente.Text))
            {
                resultado = "O cliente não pode ser vazio.";
            }

            return resultado;
        }

        private void LimparTela()
        {
            comboProd.Text = "";
            comboFilial.Text = "";
            comboCliente.Text = "";
        }
    }
}

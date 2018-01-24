namespace Exercicio15
{
    partial class FrmForcaDeVendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCadProd = new System.Windows.Forms.Button();
            this.butCadCliente = new System.Windows.Forms.Button();
            this.butCadFilial = new System.Windows.Forms.Button();
            this.butPedido = new System.Windows.Forms.Button();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.lblProdPedido = new System.Windows.Forms.Label();
            this.lblFilialPedido = new System.Windows.Forms.Label();
            this.comboFilial = new System.Windows.Forms.ComboBox();
            this.lblClientePedido = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butCadProd
            // 
            this.butCadProd.Location = new System.Drawing.Point(134, 12);
            this.butCadProd.Name = "butCadProd";
            this.butCadProd.Size = new System.Drawing.Size(107, 23);
            this.butCadProd.TabIndex = 1;
            this.butCadProd.Text = "Cadastrar produto";
            this.butCadProd.UseVisualStyleBackColor = true;
            this.butCadProd.Click += new System.EventHandler(this.butCadProd_Click);
            // 
            // butCadCliente
            // 
            this.butCadCliente.Location = new System.Drawing.Point(256, 12);
            this.butCadCliente.Name = "butCadCliente";
            this.butCadCliente.Size = new System.Drawing.Size(108, 23);
            this.butCadCliente.TabIndex = 2;
            this.butCadCliente.Text = "Cadastrar cliente";
            this.butCadCliente.UseVisualStyleBackColor = true;
            this.butCadCliente.Click += new System.EventHandler(this.butCadCliente_Click);
            // 
            // butCadFilial
            // 
            this.butCadFilial.Location = new System.Drawing.Point(12, 12);
            this.butCadFilial.Name = "butCadFilial";
            this.butCadFilial.Size = new System.Drawing.Size(107, 23);
            this.butCadFilial.TabIndex = 0;
            this.butCadFilial.Text = "Cadastrar filial";
            this.butCadFilial.UseVisualStyleBackColor = true;
            this.butCadFilial.Click += new System.EventHandler(this.butCadFilial_Click);
            // 
            // butPedido
            // 
            this.butPedido.Location = new System.Drawing.Point(12, 224);
            this.butPedido.Name = "butPedido";
            this.butPedido.Size = new System.Drawing.Size(108, 23);
            this.butPedido.TabIndex = 3;
            this.butPedido.Text = "Realizar pedido";
            this.butPedido.UseVisualStyleBackColor = true;
            this.butPedido.Click += new System.EventHandler(this.butPedido_Click);
            // 
            // comboProd
            // 
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Location = new System.Drawing.Point(12, 85);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(121, 21);
            this.comboProd.TabIndex = 4;
            this.comboProd.DropDown += new System.EventHandler(this.comboProd_DropDown);
            // 
            // lblProdPedido
            // 
            this.lblProdPedido.AutoSize = true;
            this.lblProdPedido.Location = new System.Drawing.Point(9, 69);
            this.lblProdPedido.Name = "lblProdPedido";
            this.lblProdPedido.Size = new System.Drawing.Size(94, 13);
            this.lblProdPedido.TabIndex = 5;
            this.lblProdPedido.Text = "Produto do pedido";
            // 
            // lblFilialPedido
            // 
            this.lblFilialPedido.AutoSize = true;
            this.lblFilialPedido.Location = new System.Drawing.Point(9, 118);
            this.lblFilialPedido.Name = "lblFilialPedido";
            this.lblFilialPedido.Size = new System.Drawing.Size(77, 13);
            this.lblFilialPedido.TabIndex = 6;
            this.lblFilialPedido.Text = "Filial do pedido";
            // 
            // comboFilial
            // 
            this.comboFilial.FormattingEnabled = true;
            this.comboFilial.Location = new System.Drawing.Point(12, 134);
            this.comboFilial.Name = "comboFilial";
            this.comboFilial.Size = new System.Drawing.Size(121, 21);
            this.comboFilial.TabIndex = 7;
            this.comboFilial.DropDown += new System.EventHandler(this.comboFilial_DropDown);
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.Location = new System.Drawing.Point(9, 170);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(89, 13);
            this.lblClientePedido.TabIndex = 8;
            this.lblClientePedido.Text = "Cliente do pedido";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(12, 186);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(121, 21);
            this.comboCliente.TabIndex = 9;
            this.comboCliente.DropDown += new System.EventHandler(this.comboClientePedido_DropDown);
            // 
            // FrmForcaDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.lblClientePedido);
            this.Controls.Add(this.comboFilial);
            this.Controls.Add(this.lblFilialPedido);
            this.Controls.Add(this.lblProdPedido);
            this.Controls.Add(this.comboProd);
            this.Controls.Add(this.butPedido);
            this.Controls.Add(this.butCadFilial);
            this.Controls.Add(this.butCadCliente);
            this.Controls.Add(this.butCadProd);
            this.Name = "FrmForcaDeVendas";
            this.Text = "Força de vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCadProd;
        private System.Windows.Forms.Button butCadCliente;
        private System.Windows.Forms.Button butCadFilial;
        private System.Windows.Forms.Button butPedido;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.Label lblProdPedido;
        private System.Windows.Forms.Label lblFilialPedido;
        private System.Windows.Forms.ComboBox comboFilial;
        private System.Windows.Forms.Label lblClientePedido;
        private System.Windows.Forms.ComboBox comboCliente;
    }
}


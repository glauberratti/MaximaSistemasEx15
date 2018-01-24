namespace Exercicio15
{
    partial class FrmCadProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmb = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmb = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblEmb
            // 
            this.lblEmb.AutoSize = true;
            this.lblEmb.Location = new System.Drawing.Point(12, 66);
            this.lblEmb.Name = "lblEmb";
            this.lblEmb.Size = new System.Drawing.Size(65, 13);
            this.lblEmb.TabIndex = 1;
            this.lblEmb.Text = "Embalagem:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 121);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtEmb
            // 
            this.txtEmb.Location = new System.Drawing.Point(15, 82);
            this.txtEmb.MaxLength = 50;
            this.txtEmb.Name = "txtEmb";
            this.txtEmb.Size = new System.Drawing.Size(205, 20);
            this.txtEmb.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(15, 137);
            this.txtPreco.MaxLength = 100000;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // butCadastrar
            // 
            this.butCadastrar.Location = new System.Drawing.Point(15, 178);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(75, 23);
            this.butCadastrar.TabIndex = 3;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = true;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // FrmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.butCadastrar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtEmb);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblEmb);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCadProd";
            this.Text = "FrmCadProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmb;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEmb;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button butCadastrar;
    }
}
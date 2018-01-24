namespace Exercicio15
{
    partial class FrmCadCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.radFis = new System.Windows.Forms.RadioButton();
            this.radJur = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 62);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(68, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo pessoa:";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(12, 112);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(103, 13);
            this.lblDoc.TabIndex = 2;
            this.lblDoc.Text = "Número documento:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 163);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 30);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(15, 128);
            this.txtNumDoc.MaxLength = 14;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(257, 20);
            this.txtNumDoc.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(15, 179);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(257, 20);
            this.txtTel.TabIndex = 4;
            // 
            // butCadastrar
            // 
            this.butCadastrar.Location = new System.Drawing.Point(16, 217);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(75, 23);
            this.butCadastrar.TabIndex = 5;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = true;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // radFis
            // 
            this.radFis.AutoSize = true;
            this.radFis.Location = new System.Drawing.Point(16, 78);
            this.radFis.Name = "radFis";
            this.radFis.Size = new System.Drawing.Size(54, 17);
            this.radFis.TabIndex = 1;
            this.radFis.TabStop = true;
            this.radFis.Text = "Física";
            this.radFis.UseVisualStyleBackColor = true;
            // 
            // radJur
            // 
            this.radJur.AutoSize = true;
            this.radJur.Location = new System.Drawing.Point(96, 78);
            this.radJur.Name = "radJur";
            this.radJur.Size = new System.Drawing.Size(63, 17);
            this.radJur.TabIndex = 2;
            this.radJur.TabStop = true;
            this.radJur.Text = "Jurídica";
            this.radJur.UseVisualStyleBackColor = true;
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.radJur);
            this.Controls.Add(this.radFis);
            this.Controls.Add(this.butCadastrar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadCliente";
            this.Text = "FrmCadCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button butCadastrar;
        private System.Windows.Forms.RadioButton radFis;
        private System.Windows.Forms.RadioButton radJur;
    }
}
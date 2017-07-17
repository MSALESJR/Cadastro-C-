namespace Cliente
{
    partial class frmCadastroClientes
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
            this.gpbInformacoesCliente = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.gpbInformacoesCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacoesCliente
            // 
            this.gpbInformacoesCliente.Controls.Add(this.lblTotalClientes);
            this.gpbInformacoesCliente.Controls.Add(this.btnAdicionar);
            this.gpbInformacoesCliente.Controls.Add(this.txtNome);
            this.gpbInformacoesCliente.Controls.Add(this.lblNome);
            this.gpbInformacoesCliente.Controls.Add(this.lblCodigo);
            this.gpbInformacoesCliente.Controls.Add(this.txtCodigo);
            this.gpbInformacoesCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoesCliente.Name = "gpbInformacoesCliente";
            this.gpbInformacoesCliente.Size = new System.Drawing.Size(450, 98);
            this.gpbInformacoesCliente.TabIndex = 0;
            this.gpbInformacoesCliente.TabStop = false;
            this.gpbInformacoesCliente.Text = "Informações do Cliente";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(369, 64);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(144, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(10, 71);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(0, 13);
            this.lblTotalClientes.TabIndex = 6;
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.gpbInformacoesCliente);
            this.Name = "frmCadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.gpbInformacoesCliente.ResumeLayout(false);
            this.gpbInformacoesCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacoesCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTotalClientes;
    }
}


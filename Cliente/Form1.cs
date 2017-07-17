using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmCadastroClientes : Form
    {
        private Cliente.Model.ClientesDao clientes { get; set; }

        public frmCadastroClientes()
        {
            InitializeComponent();
            this.clientes = new Cliente.Model.ClientesDao();
            AtualizarLabelTotalClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codigo = int.Parse(txtCodigo.Text);
            var nome = txtNome.Text;

            var cliente = new Cliente.Entity.Cliente() {
                Codigo = codigo,
                Nome = nome    
            };

            this.clientes.Add(cliente);
            AtualizarLabelTotalClientes();
        }

        private void AtualizarLabelTotalClientes()
        {
            lblTotalClientes.Text = "Total de Clientes : " + this.clientes.Count();
        }
    }
}

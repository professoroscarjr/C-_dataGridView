using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        private List<clsCliente> listaClientes = new List<clsCliente>();
        public Form1()
        {
            InitializeComponent();
          //  dgvDados.AutoGenerateColumns = false; // Desativa a geração automática de colunas
          //  dgvDados.Columns.Add("Nome", "Nome"); // Adiciona a coluna Nome
          //  dgvDados.Columns.Add("Email", "Email"); // Adiciona a coluna Email
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;
            string email = textEmail.Text;

            clsCliente cliente = new clsCliente(nome, email);
            listaClientes.Add(cliente);

            // Atualiza o DataGridView com a lista de clientes
            dgvDados.DataSource = null;
            dgvDados.DataSource = listaClientes;

            // Limpa as TextBox
            textNome.Clear();
            textEmail.Clear();
        }
    }
}

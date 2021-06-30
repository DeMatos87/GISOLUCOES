using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GISOLUCOES.DAL;

namespace GISOLUCOES
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Chamar o Formulário Principal a pós fechar o formulário
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //Carregamento de Cliente na base de dados
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.clientes;
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            //Adicionar ou incluir clientes.
            this.clienteBindingSource.AddNew();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            //Gravar Clientes
            if (this.ValidarCliente())
            {
                this.clienteBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                DtvCliente.Refresh();
                MessageBox.Show("Cliente gravado com sucesso", "Gravar Cliente",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private bool ValidarCliente()
        {
            if (cnpjTextBox.Text == string.Empty && nome_fantasiaTextBox.Text == string.Empty
                && razao_socialTextBox.Text == string.Empty && cepTextBox.Text == string.Empty
                && enderecoTextBox.Text == string.Empty && numeroTextBox.Text ==""
                && complementoTextBox.Text =="" && bairroTextBox.Text =="" &&cidadeTextBox.Text ==""
                && ufTextBox.Text =="")
            {
                MessageBox.Show("Os campos acima são obrigatório", "Gravar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cnpjTextBox.Focus();
                return false;
            }
            return true;
        }
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            //Deletar Clientes
            if (MessageBox.Show("Tens certeza?", "Excluir Cliente", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.ClientePossuiUsuarioAssociado(this.clienteCorrente))
                {
                    MessageBox.Show("Não pode excluir cliente associado ao usuário!",
                        "Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.clienteBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Cliente excluída com sucesso!", "Excluir Cliente",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                return;
            }

        }

        //Método para verificar se o cliente esta associado a algum usuário
        public cliente clienteCorrente
        {
            get
            {
                return (cliente)this.clienteBindingSource.Current;
            }
        }

        private bool ClientePossuiUsuarioAssociado(cliente cliente)
        {
            var usuarios = DataContextFactory.DataContext.usuarios.Where
                (x => x.cliente_id == cliente.id);
            if (usuarios.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            string ConnectionString = @"Data Source = DESKTOP-G002P8G\PRIMAVERAV9; Initial Catalog =INTEGRADOSOLUCOES; 
                                         Integrated Security = True";
            SqlConnection sqlCon = new SqlConnection(ConnectionString);
            sqlCon.ConnectionString = ConnectionString;
            sqlCon.Open();

            string query = "UPDATE usuarios SET nome =@nome,sobrenome=@sobrenome,telefone =@telefone,email=@email,senha=@senha WHERE id=@id";
            SqlCommand SqlCmd = new SqlCommand(query, sqlCon);
            SqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("Informação actualizada com sucesso!", " UPDATE QUERY", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

        }
    }
}

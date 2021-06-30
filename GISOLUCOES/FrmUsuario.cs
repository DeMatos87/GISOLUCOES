using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GISOLUCOES.DAL;
using System.Data.SqlClient;

namespace GISOLUCOES
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.usuarioBindingSource.DataSource = DataContextFactory.DataContext.usuarios;
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            //INSERIR USUÁRIOS
            this.usuarioBindingSource.AddNew();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            //Gravar Usuários
            if (Validar())
            {
                this.usuarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                DtvUsuario.Refresh();
                MessageBox.Show("Usuário gravado com sucesso!", "GravarUsuário",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Método para validar e verificar se os campos do cadastro de cliente estão vazios.
        private bool Validar()
        {
            if (nomeTextBox.Text == string.Empty && sobrenomeTextBox.Text == string.Empty
                && telefoneTextBox.Text == string.Empty && emailTextBox.Text == string.Empty
                && senhaTextBox.Text == string.Empty)
            {
                MessageBox.Show("Os campos acima são obrigatório", "Gravar Usuário",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nomeTextBox.Focus();
                return false;
            }
            return true;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            //ESCLUIR Usuários
            if (MessageBox.Show("Tens certeza?", "Excluir Usuário", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.usuarioPossuiClienteAssociado(this.UsuarioCorrente))
                {
                    MessageBox.Show("Não pode excluir usuário associado ao cliente!",
                        "Excluir Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.usuarioBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Usuário excluída com sucesso!", "Excluir Usuário",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                return;
            }
        }

        //Métodos para verificar se os usuários estão associados a clientes.
        public usuario UsuarioCorrente
        {
            get
            {
                return (usuario)this.usuarioBindingSource.Current;
            }
        }

        private bool usuarioPossuiClienteAssociado(usuario usuario)
        {
            var cliente = DataContextFactory.DataContext.clientes.Where
                (x => x.id == usuario.cliente_id);
            if (cliente.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}

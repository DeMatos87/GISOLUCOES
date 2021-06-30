using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GISOLUCOES
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Adcionar_Cliente_Click(object sender, EventArgs e)
        {
            //Chamar Formuário Cliente
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
            this.Hide();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Fechar a Aplicação
            Application.Exit();
        }

        private void btn_Adicionar_Usuario_Click(object sender, EventArgs e)
        {

            //Chamar o formulário usuário
            FrmUsuario usuario = new FrmUsuario();
            usuario.Show();
            this.Hide();
        }
    }
}

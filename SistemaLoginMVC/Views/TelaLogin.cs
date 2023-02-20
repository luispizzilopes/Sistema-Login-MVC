using SistemaLoginMVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoginMVC.Views
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();
            if(login.Acessar(txtBoxUsuario.Text, txtBoxSenha.Text))
            {
                MessageBox.Show("Acessando...", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível localizar essas informações na base de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.ShowDialog();
        }

        private void TelaLogin_Shown(object sender, EventArgs e)
        {
            if (!File.Exists("LocalBd.dll"))
            {
                MessageBox.Show("Não foi possível localizar o arquivo LocalBd.dll");
                Application.Exit();
            }
        }
    }
}

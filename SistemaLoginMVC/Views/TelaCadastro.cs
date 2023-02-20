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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();

            if (txtBoxSenha.Text == txtBoxConfirmarSenha.Text)
            {
                if(login.Cadastrar(txtBoxUsuario.Text, txtBoxSenha.Text))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Já existe o usuário informado na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("As senhas não coincidem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

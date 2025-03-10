using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senhaCorreta = "123456"; // 🔐 Defina a senha correta aqui

            if (txtSenha.Text == senhaCorreta) // Confere a senha digitada
            {
                this.DialogResult = DialogResult.OK; // Permite abrir a outra tela
                this.Close(); // Fecha a tela de login
               
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear(); // Limpa o campo senha
                txtSenha.Focus(); // Foca no campo senha
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●'; // Oculta a senha com bolinhas
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Simula o clique no botão
            }
        }

    }
}

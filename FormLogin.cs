using System;
using System.Diagnostics;
using System.Drawing;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Management;
using System.IO;





namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //CriarBotaoReiniciarChave(); // 🔹 Adiciona o botão na interface
        }



            private void CriarBotaoReiniciarChave()
            {
                // 🔹 Criando botão moderno  //exemplo
                Guna2Button btnReiniciarChave = new Guna2Button();
                btnReiniciarChave.Text = "🔄 Reiniciar Chave Datarey";
                btnReiniciarChave.Size = new Size(250, 50);
                btnReiniciarChave.Location = new Point(50, 50); // Posição no formulário
                btnReiniciarChave.BorderRadius = 15; // 🔹 Bordas arredondadas
                btnReiniciarChave.FillColor = Color.DarkBlue; // 🔹 Cor de fundo
                btnReiniciarChave.ForeColor = Color.White; // 🔹 Cor do texto
                btnReiniciarChave.Font = new Font("Arial", 12, FontStyle.Bold);
                btnReiniciarChave.HoverState.FillColor = Color.MediumBlue; // 🔹 Efeito de hover
                btnReiniciarChave.Click += BtnReiniciarChave_Click; // Evento de clique

                // 🔹 Adiciona ao formulário
                this.Controls.Add(btnReiniciarChave);
            }








            private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla ENTER foi pressionada
            if (e.KeyCode == Keys.Enter)
            {
                string senhaCorreta = "241002"; // 🔐 Defina a senha correta aqui

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
        }










        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●'; // Oculta a senha com bolinhas
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            // Nada a fazer aqui
        }












        private async void BtnReiniciarChave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("RF32"))
                {
                    process.Kill();
                    process.WaitForExit();
                }

                Process.Start("cmd.exe", "/c net stop DatareySistemas && net start DatareySistemas");

                // 🔹 Aguarda 3 segundos antes de mostrar a mensagem
                await Task.Delay(9000);

                MessageBox.Show("🔄 Chave Datarey reiniciada! Clique em OK para abrir o sistema.","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Aguarda mais 2 segundos antes de iniciar o sistema
                await Task.Delay(3000);

                Process.Start("RF32", "INICIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao reiniciar a chave: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnLimparFila_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Para o serviço de impressão (Spooler)
                Process.Start("cmd.exe", "/c net stop spooler");

                // 🔹 Aguarda um pouco para garantir que o serviço parou
                System.Threading.Thread.Sleep(2000);

                // 🔹 Deleta todos os arquivos da pasta de impressão
                string spoolerPath = @"C:\Windows\System32\spool\PRINTERS";
                if (Directory.Exists(spoolerPath))
                {
                    foreach (string file in Directory.GetFiles(spoolerPath))
                    {
                        File.Delete(file);
                    }
                }

                // 🔹 Aguarda um pouco antes de iniciar o serviço novamente
                System.Threading.Thread.Sleep(2000);

                // 🔹 Reinicia o serviço de impressão (Spooler)
                Process.Start("cmd.exe", "/c net start spooler");

                // 🔹 Aguarda um pouco antes de informar a mensagem
                System.Threading.Thread.Sleep(4000);

                MessageBox.Show("🖨️ Todas as filas de impressão foram limpas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar a fila de impressão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

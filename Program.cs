using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // para desativar a tela de login comentente as duas linhas a baixo com //
            //para voltar tire os comentario.
            //FormLogin loginForm = new FormLogin();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1()); // 🔹 Só abre o Form1 se o login for correto
            }
        }
    }
}



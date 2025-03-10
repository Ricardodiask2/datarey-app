using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarStatusRDP(); // Verifica o status da Área Remota ao iniciar
        }

        // 🔹 Atualiza o status da Área Remota
        private void AtualizarStatusRDP()
        {
            try
            {
                ServiceController service = new ServiceController("TermService");

                if (service.Status == ServiceControllerStatus.Running)
                {
                    StatusRDP.Text = "🟢 Área Remota Ativada";
                    StatusRDP.ForeColor = Color.Green;
                }
                else
                {
                    StatusRDP.Text = "🔴 Área Remota Desativada";
                    StatusRDP.ForeColor = Color.Red;
                }
            }
            catch (InvalidOperationException)
            {
                StatusRDP.Text = "⚠️ Serviço não encontrado";
                StatusRDP.ForeColor = Color.Orange;
            }
        }

        // 🔹 Desativa a Área Remota
        private void btnDesativarRDP_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe", "/c query session | find \"Active\" > temp.txt && for /F \"tokens=3\" %i in (temp.txt) do logoff %i");

                string[] dependencias = { "SessionEnv", "UmRdpService", "Netman" };
                foreach (string dep in dependencias)
                {
                    ServiceController depService = new ServiceController(dep);
                    if (depService.Status == ServiceControllerStatus.Running)
                    {
                        depService.Stop();
                        depService.WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                }

                ServiceController service = new ServiceController("TermService");
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                }

                Process.Start("cmd.exe", "/c netsh advfirewall firewall add rule name=\"Bloqueio RDP\" dir=in action=block protocol=TCP localport=3389");

                MessageBox.Show("🔴 Área Remota Desativada!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                AtualizarStatusRDP(); // Atualiza o status no Label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar a Área Remota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Ativa a Área Remota
        private void btnAtivarRDP_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe", "/c netsh advfirewall firewall delete rule name=\"Bloqueio RDP\"");

                ServiceController service = new ServiceController("TermService");
                if (service.Status == ServiceControllerStatus.Stopped || service.Status == ServiceControllerStatus.Paused)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }

                MessageBox.Show("🟢 Área Remota Ativada!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarStatusRDP(); // Atualiza o status no Label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ativar a Área Remota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Finaliza todos os processos RF32
        private void btnPararRF32_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("RF32"))
                {
                    process.Kill();
                    process.WaitForExit();
                }

                MessageBox.Show("🔴 Todos os processos RF32 foram encerrados!", "Processos Encerrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encerrar RF32: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReconstrucao_Click(object sender, EventArgs e)
        {
            try
            {
                string pastaSistema = AppDomain.CurrentDomain.BaseDirectory;
                string[] padroesArquivos = { "*.cdx", "arqtemp*", "instanci.dbf", "ctrl*", "T_*.*", "*.$*", "*.bak", "*.err", "*.ntx", "*.$MT", "*.CUP", "T_.dbf", "vend*.dbf", "*.log", "*.TXT" };

                foreach (string padrao in padroesArquivos)
                {
                    string[] arquivos = Directory.GetFiles(pastaSistema, padrao);
                    foreach (string arquivo in arquivos)
                    {
                        File.Delete(arquivo);
                    }
                }

                Process.Start("RF32", "INICIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a reconstrução: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Realiza o backup dos arquivos DBF e atualiza a barra de progresso
        // 🔹 Método para fazer backup dos arquivos DBF e atualizar a barra de progresso
        private void btnBackupDBF_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém a pasta onde o programa está sendo executado
                string pastaSistema = AppDomain.CurrentDomain.BaseDirectory;

                // Define a pasta de backup dentro da mesma pasta do sistema
                string pastaBackup = Path.Combine(pastaSistema, "BackupDBF");

                // Cria a pasta de backup se não existir
                if (!Directory.Exists(pastaBackup))
                {
                    Directory.CreateDirectory(pastaBackup);
                }

                // Pega todos os arquivos .DBF dentro da pasta do sistema
                string[] arquivosDBF = Directory.GetFiles(pastaSistema, "*.DBF");

                // Se não houver arquivos DBF, avisa e sai
                if (arquivosDBF.Length == 0)
                {
                    MessageBox.Show("Nenhum arquivo DBF encontrado na pasta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Configura a barra de progresso
                progressBarBackup.Minimum = 0;
                progressBarBackup.Maximum = arquivosDBF.Length;
                progressBarBackup.Value = 0;

                // Copia os arquivos .DBF para a pasta de backup
                foreach (string arquivo in arquivosDBF)
                {
                    string destino = Path.Combine(pastaBackup, Path.GetFileName(arquivo));
                    File.Copy(arquivo, destino, true); // Copia arquivo com sobrescrita
                    progressBarBackup.Value += 1; // Atualiza a barra de progresso
                    Application.DoEvents(); // Atualiza a interface do usuário
                }

                MessageBox.Show("📂 Backup dos arquivos DBF concluído!", "Backup Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBarBackup.Value = 0; // Reseta a barra de progresso após conclusão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar backup dos arquivos DBF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarBackup.Value = 0; // Reseta a barra de progresso em caso de erro
            }
        }




private void btnAtualizarVersao_Click(object sender, EventArgs e)
    {
        try
        {
            string url = "https://www.dropbox.com/s/q60j0ixqjcy0qpc/RF32.zip?dl=1";
            string pastaSistema = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoZip = Path.Combine(pastaSistema, "RF32.zip");
            string caminhoExtraido = Path.Combine(pastaSistema, "RF32.exe");
            string caminhoAtual = Path.Combine(pastaSistema, "RF32.exe");
            string caminhoBackup = Path.Combine(pastaSistema, "RF32.BKP");

            // 1️⃣ Baixa o arquivo ZIP do Dropbox
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, caminhoZip);
            }

            // 2️⃣ Verifica se RF32 está rodando e encerra (caso tenha esquecido de fechar)
            foreach (var process in Process.GetProcessesByName("RF32"))
            {
                process.Kill();
                process.WaitForExit();
            }

            // 3️⃣ Faz backup da versão atual
            if (File.Exists(caminhoAtual))
            {
                File.Move(caminhoAtual, caminhoBackup);
            }

            // 4️⃣ Extrai o novo arquivo
            ZipFile.ExtractToDirectory(caminhoZip, pastaSistema);

            // 5️⃣ Deleta o arquivo ZIP baixado
            File.Delete(caminhoZip);

            MessageBox.Show("✅ RF32 atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar RF32: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnVoltarVersao_Click(object sender, EventArgs e)
        {
            try
            {
                string pastaSistema = AppDomain.CurrentDomain.BaseDirectory;
                string caminhoAtual = Path.Combine(pastaSistema, "RF32.exe");
                string caminhoBackup = Path.Combine(pastaSistema, "RF32.BKP");

                // 1️⃣ Verifica se o backup existe
                if (!File.Exists(caminhoBackup))
                {
                    MessageBox.Show("❌ Nenhum backup encontrado para restaurar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Encerra o RF32 se estiver em execução
                foreach (var process in Process.GetProcessesByName("RF32"))
                {
                    try
                    {
                        process.Kill();
                        process.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("⚠️ Erro ao encerrar o processo RF32: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3️⃣ Aguarda um curto tempo para garantir que o processo foi finalizado
                System.Threading.Thread.Sleep(1000);

                // 4️⃣ Remove a versão atual (caso exista e não esteja bloqueada)
                if (File.Exists(caminhoAtual))
                {
                    try
                    {
                        File.Delete(caminhoAtual);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("⚠️ Erro ao excluir a versão atual: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 5️⃣ Restaura o backup
                try
                {
                    File.Move(caminhoBackup, caminhoAtual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Erro ao restaurar a versão anterior: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("✅ Versão anterior restaurada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}

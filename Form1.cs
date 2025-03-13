using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using Guna.UI2.WinForms;
using System.Management;
using System.Security.Cryptography;



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
                    StatusRDP.Text = "🟢 Área Remota Ativa";
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

                // Configurar a barra de progresso antes de iniciar o processo
                progressBarBackup.Visible = true;
                progressBarBackup.Minimum = 0;
                progressBarBackup.Maximum = arquivosDBF.Length;
                progressBarBackup.Value = 0;

                // Copia os arquivos .DBF para a pasta de backup
                foreach (string arquivo in arquivosDBF)
                {
                    string destino = Path.Combine(pastaBackup, Path.GetFileName(arquivo));
                    File.Copy(arquivo, destino, true); // Copia arquivo com sobrescrita

                    // Atualiza a barra de progresso, garantindo que não ultrapasse o limite
                    if (progressBarBackup.Value < progressBarBackup.Maximum)
                    {
                        progressBarBackup.Value += 1;
                    }

                    Application.DoEvents(); // Atualiza a interface do usuário para não travar
                }

                // Exibir mensagem de sucesso e ocultar a barra de progresso
                MessageBox.Show("📂 Backup dos arquivos DBF concluído!", "Backup Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar backup dos arquivos DBF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Resetar e ocultar a barra de progresso no final do processo
                progressBarBackup.Value = 0;
                progressBarBackup.Visible = false;
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

        private void btnCopiaxml_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o diretório base onde o executável está rodando
                string pastaBase = AppDomain.CurrentDomain.BaseDirectory;

                // Define as subpastas para NFCE e NFE
                string[] tipos = { "NFCE", "NFE" };

                int arquivosCopiados = 0;

                foreach (string tipo in tipos)
                {
                    string pastaTipo = Path.Combine(pastaBase, tipo);

                    // Verifica se a pasta NFCE ou NFE existe
                    if (!Directory.Exists(pastaTipo))
                        continue;

                    // Percorre as pastas de cada mês (01 a 12)
                    for (int mes = 1; mes <= 12; mes++)
                    {
                        string pastaOrigem = Path.Combine(pastaTipo, mes.ToString("D2"), "XML");

                        // Verifica se a pasta do mês existe
                        if (Directory.Exists(pastaOrigem))
                        {
                            string[] arquivosXml = Directory.GetFiles(pastaOrigem, "*.xml");

                            foreach (string caminhoArquivo in arquivosXml)
                            {
                                string conteudoXml = File.ReadAllText(caminhoArquivo);

                                // Extrai a data da tag <dhEmi> (formato: YYYY-MM-DDTHH:MM:SS)
                                int pos1 = conteudoXml.IndexOf("<dhEmi>");
                                int pos2 = conteudoXml.IndexOf("</dhEmi>");

                                if (pos1 > -1 && pos2 > pos1)
                                {
                                    string dataEmissao = conteudoXml.Substring(pos1 + 7, pos2 - pos1 - 7);
                                    string ano = dataEmissao.Substring(0, 4); // Pega o ano (YYYY)
                                    string mesXml = dataEmissao.Substring(5, 2); // Pega o mês (MM)

                                    // Criar pasta do Ano e do Mês dentro do Ano para NFCE ou NFE
                                    string novoCaminho = Path.Combine(pastaTipo, ano, mesXml);
                                    if (!Directory.Exists(novoCaminho))
                                    {
                                        Directory.CreateDirectory(novoCaminho);
                                    }

                                    // Copiar o arquivo para o destino correto
                                    string destino = Path.Combine(novoCaminho, Path.GetFileName(caminhoArquivo));

                                    if (!File.Exists(destino))
                                    {
                                        File.Copy(caminhoArquivo, destino);
                                        arquivosCopiados++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Arquivo já existe: " + destino);
                                    }
                                }
                            }
                        }
                    }
                }

                // Exibe mensagem final com o total de arquivos copiados
                MessageBox.Show($"Processo concluído! {arquivosCopiados} arquivos XML foram copiados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao organizar XMLs: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BntCopiarxml_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre o diálogo para selecionar a pasta de destino
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Selecione a pasta onde os arquivos serão organizados";

                    if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(dialog.SelectedPath))
                        return; // Se o usuário cancelar, sai da função

                    string pastaDestino = dialog.SelectedPath;

                    // Criar as pastas NFE e NFCE dentro da pasta escolhida
                    string pastaNFE = Path.Combine(pastaDestino, "NFE");
                    string pastaNFCE = Path.Combine(pastaDestino, "NFCE");

                    Directory.CreateDirectory(pastaNFE);
                    Directory.CreateDirectory(pastaNFCE);

                    // Criar arquivo de log na pasta de destino
                    string caminhoLog = Path.Combine(pastaDestino, "Log_Copias.txt");
                    List<string> logEntries = new List<string>();

                    logEntries.Add($"🔹 Processo iniciado: {DateTime.Now}");
                    logEntries.Add("--------------------------------------------------");

                    // Obtém o diretório onde o executável está rodando (onde estão os arquivos XML)
                    string pastaBase = AppDomain.CurrentDomain.BaseDirectory;

                    // Define os diretórios de origem para NFCE e NFE
                    string[] tipos = { "NFCE", "NFE" };
                    Dictionary<string, string> pastasOrigem = new Dictionary<string, string>
            {
                { "NFCE", Path.Combine(pastaBase, "NFCE") },
                { "NFE", Path.Combine(pastaBase, "NFE") }
            };
                    Dictionary<string, string> pastasDestino = new Dictionary<string, string>
            {
                { "NFCE", pastaNFCE },
                { "NFE", pastaNFE }
            };

                    int arquivosCopiadosNFE = 0;
                    int arquivosCopiadosNFCE = 0;
                    List<string> arquivosParaProcessar = new List<string>();

                    // Coletar todos os arquivos XML das pastas de origem
                    foreach (var tipo in tipos)
                    {
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            string pastaMes = Path.Combine(pastasOrigem[tipo], mes.ToString("D2"), "XML");
                            if (Directory.Exists(pastaMes))
                            {
                                arquivosParaProcessar.AddRange(Directory.GetFiles(pastaMes, "*.xml"));
                            }
                        }
                    }

                    // Se não houver arquivos para processar, exibe mensagem e sai
                    if (arquivosParaProcessar.Count == 0)
                    {
                        MessageBox.Show("Nenhum arquivo XML encontrado para organizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Configurar a barra de progresso
                    progressBarXml.Visible = true;
                    progressBarXml.Minimum = 0;
                    progressBarXml.Maximum = arquivosParaProcessar.Count;
                    progressBarXml.Value = 0;

                    // Processar os arquivos XML
                    foreach (string caminhoArquivo in arquivosParaProcessar)
                    {
                        string conteudoXml = File.ReadAllText(caminhoArquivo);

                        // Extrai a data da tag <dhEmi> (formato: YYYY-MM-DDTHH:MM:SS)
                        int pos1 = conteudoXml.IndexOf("<dhEmi>");
                        int pos2 = conteudoXml.IndexOf("</dhEmi>");

                        if (pos1 > -1 && pos2 > pos1)
                        {
                            string dataEmissao = conteudoXml.Substring(pos1 + 7, pos2 - pos1 - 7);
                            string ano = dataEmissao.Substring(0, 4); // Pega o ano (YYYY)
                            string mesXml = dataEmissao.Substring(5, 2); // Pega o mês (MM)

                            // Identificar se o arquivo pertence a NFCE ou NFE
                            string tipo = caminhoArquivo.Contains("\\NFCE\\") ? "NFCE" : "NFE";
                            string destinoBase = pastasDestino[tipo];

                            // Criar pasta do Ano e do Mês dentro de NFE/NFCE
                            string novoCaminho = Path.Combine(destinoBase, ano, mesXml);
                            if (!Directory.Exists(novoCaminho))
                            {
                                Directory.CreateDirectory(novoCaminho);
                            }

                            // Copiar o arquivo para o destino correto
                            string destino = Path.Combine(novoCaminho, Path.GetFileName(caminhoArquivo));

                            if (!File.Exists(destino))
                            {
                                File.Copy(caminhoArquivo, destino);

                                // Atualiza contagem e log
                                if (tipo == "NFE")
                                    arquivosCopiadosNFE++;
                                else
                                    arquivosCopiadosNFCE++;

                                logEntries.Add($"✔ Copiado: {Path.GetFileName(caminhoArquivo)} → {tipo}/{ano}/{mesXml}");
                            }
                        }

                        // Atualizar a barra de progresso, garantindo que não ultrapasse o máximo
                        if (progressBarXml.Value < progressBarXml.Maximum)
                        {
                            progressBarXml.Value++;
                        }

                        Application.DoEvents();
                    }

                    // Escrever resumo no log
                    logEntries.Add("--------------------------------------------------");
                    logEntries.Add($"📌 Total de arquivos copiados para NFE: {arquivosCopiadosNFE}");
                    logEntries.Add($"📌 Total de arquivos copiados para NFCE: {arquivosCopiadosNFCE}");
                    logEntries.Add($"🔚 Processo finalizado: {DateTime.Now}");
                    logEntries.Add("\n");

                    // Gravar log no arquivo
                    File.AppendAllLines(caminhoLog, logEntries);

                    // Esconder a barra de progresso ao finalizar
                    progressBarXml.Visible = false;

                    // Exibe mensagem final com o total de arquivos copiados
                    MessageBox.Show($"Processo concluído! {arquivosCopiadosNFE + arquivosCopiadosNFCE} arquivos XML foram copiados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao organizar XMLs: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnRemoverXML_Click(object sender, EventArgs e)
        {
            //Ricardo Dias
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha todas as janelas e reinicia o aplicativo
            Application.Restart();
            Environment.Exit(0); // Garante que todos os processos sejam encerrados
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }







        private void btnRemoverCertificados_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Remove certificados do usuário atual
                RemoverCertificadosPessoais();

                MessageBox.Show("✅ Certificados digitais removidos do usuário atual!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover certificados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Remove os certificados do usuário atual
        private void RemoverCertificadosPessoais()
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadWrite);

                foreach (X509Certificate2 cert in store.Certificates)
                {
                    store.Remove(cert);
                }

                store.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover certificados do usuário atual: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnSelecionarCertificado_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Certificados PFX (*.pfx)|*.pfx",
                Title = "Selecione um Certificado Digital",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoCertificado.Text = openFileDialog.FileName; // Exibe o caminho no TextBox
            }
        }














        // 🔹 Evento que muda a aparência do campo de senha ao digitar
        private void txtSenhaCertificado_TextChanged(object sender, EventArgs e)
        {
            txtSenhaCertificado.PasswordChar = '●';
            txtSenhaCertificado.UseSystemPasswordChar = true;
            txtSenhaCertificado.BorderRadius = 8;
            txtSenhaCertificado.FillColor = Color.WhiteSmoke;
            txtSenhaCertificado.ForeColor = Color.Black;
            txtSenhaCertificado.BorderColor = Color.Gray;
            txtSenhaCertificado.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        // 🔹 Evento que detecta quando a tecla ENTER é pressionada
        private void txtSenhaCertificado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInstalarCertificado.PerformClick(); // Simula o clique no botão de instalação
                e.SuppressKeyPress = true; // Evita o "bip" da tecla Enter
            }
        }








        private void txtCaminhoCertificado_TextChanged(object sender, EventArgs e)
        {
            txtCaminhoCertificado.ReadOnly = true;
            txtCaminhoCertificado.FillColor = Color.WhiteSmoke;
            txtCaminhoCertificado.BorderRadius = 8;
            txtCaminhoCertificado.BorderColor = Color.Gray;
            txtCaminhoCertificado.ForeColor = Color.DarkBlue;
            txtCaminhoCertificado.Font = new Font("Arial", 10, FontStyle.Bold);
        }








        private void btnInstalarCertificado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaminhoCertificado.Text))
            {
                MessageBox.Show("⚠ Selecione um certificado antes de instalar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenhaCertificado.Text))
            {
                MessageBox.Show("⚠ Digite a senha do certificado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoCertificado = txtCaminhoCertificado.Text;
            string senha = txtSenhaCertificado.Text;

            try
            {
                X509Certificate2 certificado = new X509Certificate2(caminhoCertificado, senha, X509KeyStorageFlags.PersistKeySet);
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadWrite);
                store.Add(certificado);
                store.Close();

                MessageBox.Show("✅ Certificado instalado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao instalar o certificado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StatusRDP_Click(object sender, EventArgs e)
        {

        }
    }
}


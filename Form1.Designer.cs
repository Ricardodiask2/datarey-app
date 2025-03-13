namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltarVersao = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrocarVersaoRF32 = new Guna.UI2.WinForms.Guna2Button();
            this.btnReconstrucao = new Guna.UI2.WinForms.Guna2Button();
            this.progressBarBackup = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnBackupDBF = new Guna.UI2.WinForms.Guna2Button();
            this.btnPararRF32 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusRDP = new System.Windows.Forms.Label();
            this.btnDesativarRDP = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtivarRDP = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtCaminhoCertificado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInstalarCertificado = new Guna.UI2.WinForms.Guna2Button();
            this.txtSenhaCertificado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLocalizarCertificado = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverCertificados = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBarXml = new System.Windows.Forms.ProgressBar();
            this.BtnRemoverXML = new System.Windows.Forms.Button();
            this.BntCopiarxml = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(998, 559);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 24);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage7);
            this.guna2TabControl1.Controls.Add(this.tabPage8);
            this.guna2TabControl1.Controls.Add(this.tabPage9);
            this.guna2TabControl1.Controls.Add(this.tabPage10);
            this.guna2TabControl1.Controls.Add(this.tabPage11);
            this.guna2TabControl1.Controls.Add(this.tabPage12);
            this.guna2TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(3, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.ShowToolTips = true;
            this.guna2TabControl1.Size = new System.Drawing.Size(1094, 556);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 2;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            this.tabPage7.Controls.Add(this.guna2GroupBox2);
            this.tabPage7.Controls.Add(this.guna2GroupBox1);
            this.tabPage7.Location = new System.Drawing.Point(184, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(906, 548);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Reyfarma/Reyloja";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.btnVoltarVersao);
            this.guna2GroupBox2.Controls.Add(this.btnTrocarVersaoRF32);
            this.guna2GroupBox2.Controls.Add(this.btnReconstrucao);
            this.guna2GroupBox2.Controls.Add(this.progressBarBackup);
            this.guna2GroupBox2.Controls.Add(this.btnBackupDBF);
            this.guna2GroupBox2.Controls.Add(this.btnPararRF32);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(1, 207);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(900, 342);
            this.guna2GroupBox2.TabIndex = 15;
            this.guna2GroupBox2.Text = "Reconstrução";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(686, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cuidado em...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(544, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Um BKP da versão antiga será mantido.";
            // 
            // btnVoltarVersao
            // 
            this.btnVoltarVersao.BorderRadius = 5;
            this.btnVoltarVersao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarVersao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarVersao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltarVersao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltarVersao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoltarVersao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltarVersao.ForeColor = System.Drawing.Color.White;
            this.btnVoltarVersao.Location = new System.Drawing.Point(778, 103);
            this.btnVoltarVersao.Name = "btnVoltarVersao";
            this.btnVoltarVersao.Size = new System.Drawing.Size(116, 31);
            this.btnVoltarVersao.TabIndex = 19;
            this.btnVoltarVersao.Text = "Voltar Versão";
            this.btnVoltarVersao.Click += new System.EventHandler(this.btnVoltarVersao_Click);
            // 
            // btnTrocarVersaoRF32
            // 
            this.btnTrocarVersaoRF32.BorderRadius = 5;
            this.btnTrocarVersaoRF32.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrocarVersaoRF32.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrocarVersaoRF32.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrocarVersaoRF32.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrocarVersaoRF32.FillColor = System.Drawing.Color.Red;
            this.btnTrocarVersaoRF32.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrocarVersaoRF32.ForeColor = System.Drawing.Color.White;
            this.btnTrocarVersaoRF32.Location = new System.Drawing.Point(778, 53);
            this.btnTrocarVersaoRF32.Name = "btnTrocarVersaoRF32";
            this.btnTrocarVersaoRF32.Size = new System.Drawing.Size(116, 31);
            this.btnTrocarVersaoRF32.TabIndex = 18;
            this.btnTrocarVersaoRF32.Text = "Atualizar Versão";
            this.btnTrocarVersaoRF32.Click += new System.EventHandler(this.btnAtualizarVersao_Click);
            // 
            // btnReconstrucao
            // 
            this.btnReconstrucao.BorderRadius = 5;
            this.btnReconstrucao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReconstrucao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReconstrucao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReconstrucao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReconstrucao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReconstrucao.ForeColor = System.Drawing.Color.White;
            this.btnReconstrucao.Location = new System.Drawing.Point(10, 199);
            this.btnReconstrucao.Name = "btnReconstrucao";
            this.btnReconstrucao.Size = new System.Drawing.Size(116, 31);
            this.btnReconstrucao.TabIndex = 17;
            this.btnReconstrucao.Text = "Reconstruçao";
            this.btnReconstrucao.Click += new System.EventHandler(this.btnReconstrucao_Click);
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(132, 130);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(353, 31);
            this.progressBarBackup.TabIndex = 16;
            this.progressBarBackup.Text = "guna2ProgressBar1";
            this.progressBarBackup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnBackupDBF
            // 
            this.btnBackupDBF.BorderRadius = 5;
            this.btnBackupDBF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackupDBF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackupDBF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackupDBF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackupDBF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackupDBF.ForeColor = System.Drawing.Color.White;
            this.btnBackupDBF.Location = new System.Drawing.Point(10, 130);
            this.btnBackupDBF.Name = "btnBackupDBF";
            this.btnBackupDBF.Size = new System.Drawing.Size(116, 31);
            this.btnBackupDBF.TabIndex = 15;
            this.btnBackupDBF.Text = "BKP DBF";
            this.btnBackupDBF.Click += new System.EventHandler(this.btnBackupDBF_Click);
            // 
            // btnPararRF32
            // 
            this.btnPararRF32.BorderRadius = 5;
            this.btnPararRF32.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPararRF32.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPararRF32.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPararRF32.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPararRF32.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPararRF32.ForeColor = System.Drawing.Color.White;
            this.btnPararRF32.Location = new System.Drawing.Point(10, 61);
            this.btnPararRF32.Name = "btnPararRF32";
            this.btnPararRF32.Size = new System.Drawing.Size(116, 31);
            this.btnPararRF32.TabIndex = 14;
            this.btnPararRF32.Text = "Fechar RF32";
            this.btnPararRF32.Click += new System.EventHandler(this.btnPararRF32_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha todos os sistemas abertos.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Um BKP da versão será feito.";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GroupBox1.Controls.Add(this.groupBox1);
            this.guna2GroupBox1.Controls.Add(this.btnDesativarRDP);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.btnAtivarRDP);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1, 1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(902, 200);
            this.guna2GroupBox1.TabIndex = 14;
            this.guna2GroupBox1.Text = "Área Remota";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.StatusRDP);
            this.groupBox1.Location = new System.Drawing.Point(618, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // StatusRDP
            // 
            this.StatusRDP.AutoSize = true;
            this.StatusRDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusRDP.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.StatusRDP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusRDP.Location = new System.Drawing.Point(6, 28);
            this.StatusRDP.Name = "StatusRDP";
            this.StatusRDP.Size = new System.Drawing.Size(64, 27);
            this.StatusRDP.TabIndex = 1;
            this.StatusRDP.Text = "Status";
            this.StatusRDP.Click += new System.EventHandler(this.StatusRDP_Click);
            // 
            // btnDesativarRDP
            // 
            this.btnDesativarRDP.BorderRadius = 5;
            this.btnDesativarRDP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarRDP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarRDP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesativarRDP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesativarRDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesativarRDP.ForeColor = System.Drawing.Color.White;
            this.btnDesativarRDP.Location = new System.Drawing.Point(10, 62);
            this.btnDesativarRDP.Name = "btnDesativarRDP";
            this.btnDesativarRDP.Size = new System.Drawing.Size(116, 31);
            this.btnDesativarRDP.TabIndex = 7;
            this.btnDesativarRDP.Text = "Desativar RDP";
            this.btnDesativarRDP.Click += new System.EventHandler(this.btnDesativarRDP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desativa a área remota, e desconecta os usuários logados.";
            // 
            // btnAtivarRDP
            // 
            this.btnAtivarRDP.BorderRadius = 5;
            this.btnAtivarRDP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtivarRDP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtivarRDP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtivarRDP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtivarRDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtivarRDP.ForeColor = System.Drawing.Color.White;
            this.btnAtivarRDP.Location = new System.Drawing.Point(10, 133);
            this.btnAtivarRDP.Name = "btnAtivarRDP";
            this.btnAtivarRDP.Size = new System.Drawing.Size(116, 31);
            this.btnAtivarRDP.TabIndex = 8;
            this.btnAtivarRDP.Text = "Ativar RDP";
            this.btnAtivarRDP.Click += new System.EventHandler(this.btnAtivarRDP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ativa a área remota.";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.guna2HtmlLabel1);
            this.tabPage8.Location = new System.Drawing.Point(184, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(906, 548);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "SNGPC";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.guna2GroupBox4);
            this.tabPage9.Controls.Add(this.guna2GroupBox3);
            this.tabPage9.Location = new System.Drawing.Point(184, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(906, 548);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Certificado Digital";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.tabPage9.Enter += new System.EventHandler(this.txtSenhaCertificado_TextChanged);
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.txtCaminhoCertificado);
            this.guna2GroupBox4.Controls.Add(this.btnInstalarCertificado);
            this.guna2GroupBox4.Controls.Add(this.txtSenhaCertificado);
            this.guna2GroupBox4.Controls.Add(this.btnLocalizarCertificado);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(2, 165);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(904, 200);
            this.guna2GroupBox4.TabIndex = 1;
            this.guna2GroupBox4.Text = "Intalar Novo Certificado.";
            // 
            // txtCaminhoCertificado
            // 
            this.txtCaminhoCertificado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaminhoCertificado.DefaultText = "";
            this.txtCaminhoCertificado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCaminhoCertificado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCaminhoCertificado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaminhoCertificado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaminhoCertificado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaminhoCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCaminhoCertificado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaminhoCertificado.Location = new System.Drawing.Point(154, 53);
            this.txtCaminhoCertificado.Name = "txtCaminhoCertificado";
            this.txtCaminhoCertificado.PlaceholderText = "";
            this.txtCaminhoCertificado.SelectedText = "";
            this.txtCaminhoCertificado.Size = new System.Drawing.Size(744, 31);
            this.txtCaminhoCertificado.TabIndex = 5;
            this.txtCaminhoCertificado.TextChanged += new System.EventHandler(this.txtCaminhoCertificado_TextChanged);
            // 
            // btnInstalarCertificado
            // 
            this.btnInstalarCertificado.BorderRadius = 5;
            this.btnInstalarCertificado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInstalarCertificado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInstalarCertificado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInstalarCertificado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInstalarCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInstalarCertificado.ForeColor = System.Drawing.Color.White;
            this.btnInstalarCertificado.Location = new System.Drawing.Point(3, 147);
            this.btnInstalarCertificado.Name = "btnInstalarCertificado";
            this.btnInstalarCertificado.Size = new System.Drawing.Size(116, 31);
            this.btnInstalarCertificado.TabIndex = 4;
            this.btnInstalarCertificado.Text = "Instalar";
            this.btnInstalarCertificado.Click += new System.EventHandler(this.btnInstalarCertificado_Click);
            // 
            // txtSenhaCertificado
            // 
            this.txtSenhaCertificado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenhaCertificado.DefaultText = "";
            this.txtSenhaCertificado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenhaCertificado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenhaCertificado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenhaCertificado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenhaCertificado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenhaCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenhaCertificado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenhaCertificado.Location = new System.Drawing.Point(51, 101);
            this.txtSenhaCertificado.Name = "txtSenhaCertificado";
            this.txtSenhaCertificado.PlaceholderText = "";
            this.txtSenhaCertificado.SelectedText = "";
            this.txtSenhaCertificado.Size = new System.Drawing.Size(116, 31);
            this.txtSenhaCertificado.TabIndex = 3;
            this.txtSenhaCertificado.TextChanged += new System.EventHandler(this.txtSenhaCertificado_TextChanged);
            this.txtSenhaCertificado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaCertificado_KeyDown);
            // 
            // btnLocalizarCertificado
            // 
            this.btnLocalizarCertificado.BorderRadius = 5;
            this.btnLocalizarCertificado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocalizarCertificado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocalizarCertificado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocalizarCertificado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocalizarCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocalizarCertificado.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarCertificado.Location = new System.Drawing.Point(4, 53);
            this.btnLocalizarCertificado.Name = "btnLocalizarCertificado";
            this.btnLocalizarCertificado.Size = new System.Drawing.Size(144, 31);
            this.btnLocalizarCertificado.TabIndex = 1;
            this.btnLocalizarCertificado.Text = "Loca. Certificado";
            this.btnLocalizarCertificado.Click += new System.EventHandler(this.btnSelecionarCertificado_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.label3);
            this.guna2GroupBox3.Controls.Add(this.btnRemoverCertificados);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(2, 1);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(904, 158);
            this.guna2GroupBox3.TabIndex = 0;
            this.guna2GroupBox3.Text = "Remover Certificado Vencido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clique para remover/desinstalar o certificado digital.";
            // 
            // btnRemoverCertificados
            // 
            this.btnRemoverCertificados.BorderRadius = 5;
            this.btnRemoverCertificados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoverCertificados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoverCertificados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoverCertificados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoverCertificados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoverCertificados.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCertificados.Location = new System.Drawing.Point(6, 69);
            this.btnRemoverCertificados.Name = "btnRemoverCertificados";
            this.btnRemoverCertificados.Size = new System.Drawing.Size(116, 31);
            this.btnRemoverCertificados.TabIndex = 0;
            this.btnRemoverCertificados.Text = "Remover ";
            this.btnRemoverCertificados.Click += new System.EventHandler(this.btnRemoverCertificados_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.guna2HtmlLabel2);
            this.tabPage10.Location = new System.Drawing.Point(184, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(906, 548);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "PDV / Terminal";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.label2);
            this.tabPage11.Controls.Add(this.label10);
            this.tabPage11.Controls.Add(this.progressBarXml);
            this.tabPage11.Controls.Add(this.BtnRemoverXML);
            this.tabPage11.Controls.Add(this.BntCopiarxml);
            this.tabPage11.Location = new System.Drawing.Point(184, 4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(906, 548);
            this.tabPage11.TabIndex = 4;
            this.tabPage11.Text = "XML NF-e / NFC-e";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Deleta da pasta importar, os XML que já teve entrada.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Deleta da pasta importar, os XML que já teve entrada.";
            // 
            // progressBarXml
            // 
            this.progressBarXml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarXml.Location = new System.Drawing.Point(123, 34);
            this.progressBarXml.Name = "progressBarXml";
            this.progressBarXml.Size = new System.Drawing.Size(104, 29);
            this.progressBarXml.Step = 1;
            this.progressBarXml.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarXml.TabIndex = 10;
            this.progressBarXml.Visible = false;
            // 
            // BtnRemoverXML
            // 
            this.BtnRemoverXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnRemoverXML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRemoverXML.Location = new System.Drawing.Point(6, 283);
            this.BtnRemoverXML.Name = "BtnRemoverXML";
            this.BtnRemoverXML.Size = new System.Drawing.Size(111, 30);
            this.BtnRemoverXML.TabIndex = 1;
            this.BtnRemoverXML.Text = "Delete XML";
            this.BtnRemoverXML.UseVisualStyleBackColor = true;
            this.BtnRemoverXML.Click += new System.EventHandler(this.BtnRemoverXML_Click);
            // 
            // BntCopiarxml
            // 
            this.BntCopiarxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BntCopiarxml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BntCopiarxml.Location = new System.Drawing.Point(6, 33);
            this.BntCopiarxml.Name = "BntCopiarxml";
            this.BntCopiarxml.Size = new System.Drawing.Size(111, 30);
            this.BntCopiarxml.TabIndex = 1;
            this.BntCopiarxml.Text = "Organizar XML";
            this.BntCopiarxml.UseVisualStyleBackColor = true;
            this.BntCopiarxml.Click += new System.EventHandler(this.BntCopiarxml_Click);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.guna2HtmlLabel3);
            this.tabPage12.Location = new System.Drawing.Point(184, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(906, 548);
            this.tabPage12.TabIndex = 5;
            this.tabPage12.Text = "Log / Relatório";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(400, 280);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(64, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Em processo ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(421, 267);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 15);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Em processo ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(421, 267);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(64, 15);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Em processo ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 587);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnRemoverXML;
        private System.Windows.Forms.ProgressBar progressBarXml;
        private System.Windows.Forms.Button BntCopiarxml;
        private System.Windows.Forms.TabPage tabPage7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDesativarRDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusRDP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAtivarRDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button btnLocalizarCertificado;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnInstalarCertificado;
        private Guna.UI2.WinForms.Guna2TextBox txtSenhaCertificado;
        private Guna.UI2.WinForms.Guna2TextBox txtCaminhoCertificado;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPararRF32;
        private Guna.UI2.WinForms.Guna2Button btnBackupDBF;
        private Guna.UI2.WinForms.Guna2Button btnReconstrucao;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBarBackup;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnVoltarVersao;
        private Guna.UI2.WinForms.Guna2Button btnTrocarVersaoRF32;
        private Guna.UI2.WinForms.Guna2Button btnRemoverCertificados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}


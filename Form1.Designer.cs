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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVoltarVersao = new System.Windows.Forms.Button();
            this.btnTrocarVersaoRF32 = new System.Windows.Forms.Button();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.btnReconstrucao = new System.Windows.Forms.Button();
            this.btnBackupDBF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPararRF32 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusRDP = new System.Windows.Forms.Label();
            this.btnAtivarRDP = new System.Windows.Forms.Button();
            this.btnDesativarRDP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnRemoverXML = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBarXml = new System.Windows.Forms.ProgressBar();
            this.BntCopiarxml = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reyfarma/Reyloja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Manutenção";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnVoltarVersao);
            this.groupBox1.Controls.Add(this.btnTrocarVersaoRF32);
            this.groupBox1.Controls.Add(this.progressBarBackup);
            this.groupBox1.Controls.Add(this.btnReconstrucao);
            this.groupBox1.Controls.Add(this.btnBackupDBF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPararRF32);
            this.groupBox1.Location = new System.Drawing.Point(14, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(625, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Um BKP da versão será feito.";
            // 
            // btnVoltarVersao
            // 
            this.btnVoltarVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarVersao.Location = new System.Drawing.Point(797, 68);
            this.btnVoltarVersao.Name = "btnVoltarVersao";
            this.btnVoltarVersao.Size = new System.Drawing.Size(120, 31);
            this.btnVoltarVersao.TabIndex = 12;
            this.btnVoltarVersao.Text = "Voltar Versão";
            this.btnVoltarVersao.UseVisualStyleBackColor = true;
            this.btnVoltarVersao.Click += new System.EventHandler(this.btnVoltarVersao_Click);
            // 
            // btnTrocarVersaoRF32
            // 
            this.btnTrocarVersaoRF32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarVersaoRF32.Location = new System.Drawing.Point(797, 31);
            this.btnTrocarVersaoRF32.Name = "btnTrocarVersaoRF32";
            this.btnTrocarVersaoRF32.Size = new System.Drawing.Size(120, 31);
            this.btnTrocarVersaoRF32.TabIndex = 11;
            this.btnTrocarVersaoRF32.Text = "Atualizar Versão";
            this.btnTrocarVersaoRF32.UseVisualStyleBackColor = true;
            this.btnTrocarVersaoRF32.Click += new System.EventHandler(this.btnAtualizarVersao_Click);
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(133, 76);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(217, 31);
            this.progressBarBackup.Step = 1;
            this.progressBarBackup.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBackup.TabIndex = 10;
            this.progressBarBackup.Visible = false;
            
            // 
            // btnReconstrucao
            // 
            this.btnReconstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconstrucao.Location = new System.Drawing.Point(8, 119);
            this.btnReconstrucao.Name = "btnReconstrucao";
            this.btnReconstrucao.Size = new System.Drawing.Size(115, 31);
            this.btnReconstrucao.TabIndex = 9;
            this.btnReconstrucao.Text = "Reconstrução";
            this.btnReconstrucao.UseVisualStyleBackColor = true;
            this.btnReconstrucao.Click += new System.EventHandler(this.btnReconstrucao_Click);
            // 
            // btnBackupDBF
            // 
            this.btnBackupDBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDBF.Location = new System.Drawing.Point(8, 76);
            this.btnBackupDBF.Name = "btnBackupDBF";
            this.btnBackupDBF.Size = new System.Drawing.Size(116, 31);
            this.btnBackupDBF.TabIndex = 8;
            this.btnBackupDBF.Text = "BKP DBF";
            this.btnBackupDBF.UseVisualStyleBackColor = true;
            this.btnBackupDBF.Click += new System.EventHandler(this.btnBackupDBF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(130, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha todos os sistemas abertos.";
            // 
            // btnPararRF32
            // 
            this.btnPararRF32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararRF32.Location = new System.Drawing.Point(8, 31);
            this.btnPararRF32.Name = "btnPararRF32";
            this.btnPararRF32.Size = new System.Drawing.Size(116, 31);
            this.btnPararRF32.TabIndex = 0;
            this.btnPararRF32.Text = "Encerrar RF32";
            this.btnPararRF32.UseVisualStyleBackColor = true;
            this.btnPararRF32.Click += new System.EventHandler(this.btnPararRF32_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área Remota";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.StatusRDP);
            this.groupBox2.Controls.Add(this.btnAtivarRDP);
            this.groupBox2.Controls.Add(this.btnDesativarRDP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ativa a área remota.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // StatusRDP
            // 
            this.StatusRDP.AutoSize = true;
            this.StatusRDP.Location = new System.Drawing.Point(732, 67);
            this.StatusRDP.Name = "StatusRDP";
            this.StatusRDP.Size = new System.Drawing.Size(48, 17);
            this.StatusRDP.TabIndex = 1;
            this.StatusRDP.Text = "Status";
            // 
            // btnAtivarRDP
            // 
            this.btnAtivarRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarRDP.Location = new System.Drawing.Point(16, 75);
            this.btnAtivarRDP.Name = "btnAtivarRDP";
            this.btnAtivarRDP.Size = new System.Drawing.Size(103, 31);
            this.btnAtivarRDP.TabIndex = 4;
            this.btnAtivarRDP.Text = "Ativar RDP";
            this.btnAtivarRDP.UseVisualStyleBackColor = true;
            this.btnAtivarRDP.Click += new System.EventHandler(this.btnAtivarRDP_Click);
            // 
            // btnDesativarRDP
            // 
            this.btnDesativarRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativarRDP.Location = new System.Drawing.Point(16, 12);
            this.btnDesativarRDP.Name = "btnDesativarRDP";
            this.btnDesativarRDP.Size = new System.Drawing.Size(103, 31);
            this.btnDesativarRDP.TabIndex = 0;
            this.btnDesativarRDP.Text = "Parar RDP";
            this.btnDesativarRDP.UseVisualStyleBackColor = true;
            this.btnDesativarRDP.Click += new System.EventHandler(this.btnDesativarRDP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desativa a área remota, e desconecta os usuários logados.";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SNGPC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(953, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Certificado Digital";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(953, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PDV / Terminal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(953, 472);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "XML NF-e / NFC-e";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.BtnRemoverXML);
            this.groupBox4.Location = new System.Drawing.Point(9, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(928, 153);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Deleta da pasta importar, os XML que já teve entrada.";
            // 
            // BtnRemoverXML
            // 
            this.BtnRemoverXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverXML.Location = new System.Drawing.Point(6, 36);
            this.BtnRemoverXML.Name = "BtnRemoverXML";
            this.BtnRemoverXML.Size = new System.Drawing.Size(111, 30);
            this.BtnRemoverXML.TabIndex = 1;
            this.BtnRemoverXML.Text = "Delete XML";
            this.BtnRemoverXML.UseVisualStyleBackColor = true;
            this.BtnRemoverXML.Click += new System.EventHandler(this.BtnRemoverXML_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "XML de Entrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBarXml);
            this.groupBox3.Controls.Add(this.BntCopiarxml);
            this.groupBox3.Location = new System.Drawing.Point(9, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(928, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // progressBarXml
            // 
            this.progressBarXml.Location = new System.Drawing.Point(128, 36);
            this.progressBarXml.Name = "progressBarXml";
            this.progressBarXml.Size = new System.Drawing.Size(104, 29);
            this.progressBarXml.Step = 1;
            this.progressBarXml.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarXml.TabIndex = 10;
            this.progressBarXml.Visible = false;
            // 
            // BntCopiarxml
            // 
            this.BntCopiarxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCopiarxml.Location = new System.Drawing.Point(6, 36);
            this.BntCopiarxml.Name = "BntCopiarxml";
            this.BntCopiarxml.Size = new System.Drawing.Size(111, 30);
            this.BntCopiarxml.TabIndex = 1;
            this.BntCopiarxml.Text = "Organizar XML";
            this.BntCopiarxml.UseVisualStyleBackColor = true;
            this.BntCopiarxml.Click += new System.EventHandler(this.BntCopiarxml_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Organizar XML ";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(953, 472);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Log / Relatório";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 525);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnDesativarRDP;
        private System.Windows.Forms.Label StatusRDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtivarRDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPararRF32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReconstrucao;
        private System.Windows.Forms.Button btnBackupDBF;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.Button btnTrocarVersaoRF32;
        private System.Windows.Forms.Button btnVoltarVersao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BntCopiarxml;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBarXml;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnRemoverXML;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


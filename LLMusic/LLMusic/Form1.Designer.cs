namespace LLMusic
{
    partial class FormLLMusic
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
            this.MenuArquivo = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenArq = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnContinua = new System.Windows.Forms.Button();
            this.BtnDeleta = new System.Windows.Forms.Button();
            this.BtnDeleta2 = new System.Windows.Forms.Button();
            this.BtnPlaySelec = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.TreeMostra = new System.Windows.Forms.TreeView();
            this.BtnAleatório = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnDeletaQlq = new System.Windows.Forms.Button();
            this.MenuArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.MenuArquivo.Location = new System.Drawing.Point(0, 0);
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(800, 24);
            this.MenuArquivo.TabIndex = 0;
            this.MenuArquivo.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(603, 42);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnContinua
            // 
            this.BtnContinua.Location = new System.Drawing.Point(603, 71);
            this.BtnContinua.Name = "BtnContinua";
            this.BtnContinua.Size = new System.Drawing.Size(75, 23);
            this.BtnContinua.TabIndex = 4;
            this.BtnContinua.Text = "Continua";
            this.BtnContinua.UseVisualStyleBackColor = true;
            this.BtnContinua.Click += new System.EventHandler(this.BtnContinua_Click);
            // 
            // BtnDeleta
            // 
            this.BtnDeleta.Location = new System.Drawing.Point(471, 71);
            this.BtnDeleta.Name = "BtnDeleta";
            this.BtnDeleta.Size = new System.Drawing.Size(122, 23);
            this.BtnDeleta.TabIndex = 5;
            this.BtnDeleta.Text = "Deleta primeira música";
            this.BtnDeleta.UseVisualStyleBackColor = true;
            this.BtnDeleta.Click += new System.EventHandler(this.BtnDeleta_Click);
            // 
            // BtnDeleta2
            // 
            this.BtnDeleta2.Location = new System.Drawing.Point(471, 100);
            this.BtnDeleta2.Name = "BtnDeleta2";
            this.BtnDeleta2.Size = new System.Drawing.Size(122, 23);
            this.BtnDeleta2.TabIndex = 6;
            this.BtnDeleta2.Text = "Deleta última música";
            this.BtnDeleta2.UseVisualStyleBackColor = true;
            this.BtnDeleta2.Click += new System.EventHandler(this.BtnDeleta2_Click);
            // 
            // BtnPlaySelec
            // 
            this.BtnPlaySelec.Location = new System.Drawing.Point(471, 42);
            this.BtnPlaySelec.Name = "BtnPlaySelec";
            this.BtnPlaySelec.Size = new System.Drawing.Size(122, 23);
            this.BtnPlaySelec.TabIndex = 7;
            this.BtnPlaySelec.Text = "Play música selected";
            this.BtnPlaySelec.UseVisualStyleBackColor = true;
            this.BtnPlaySelec.Click += new System.EventHandler(this.BtnPlaySelec_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(603, 100);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // TreeMostra
            // 
            this.TreeMostra.Location = new System.Drawing.Point(0, 27);
            this.TreeMostra.Name = "TreeMostra";
            this.TreeMostra.Size = new System.Drawing.Size(448, 325);
            this.TreeMostra.TabIndex = 9;
            // 
            // BtnAleatório
            // 
            this.BtnAleatório.Location = new System.Drawing.Point(603, 129);
            this.BtnAleatório.Name = "BtnAleatório";
            this.BtnAleatório.Size = new System.Drawing.Size(75, 23);
            this.BtnAleatório.TabIndex = 10;
            this.BtnAleatório.Text = "Aleatório";
            this.BtnAleatório.UseVisualStyleBackColor = true;
            this.BtnAleatório.Click += new System.EventHandler(this.BtnAleatório_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(471, 129);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(122, 23);
            this.BtnProximo.TabIndex = 11;
            this.BtnProximo.Text = "Próxima Música";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnDeletaQlq
            // 
            this.BtnDeletaQlq.Location = new System.Drawing.Point(471, 158);
            this.BtnDeletaQlq.Name = "BtnDeletaQlq";
            this.BtnDeletaQlq.Size = new System.Drawing.Size(207, 23);
            this.BtnDeletaQlq.TabIndex = 12;
            this.BtnDeletaQlq.Text = "Deleta música selected";
            this.BtnDeletaQlq.UseVisualStyleBackColor = true;
            this.BtnDeletaQlq.Click += new System.EventHandler(this.BtnDeletaQlq_Click);
            // 
            // FormLLMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeletaQlq);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAleatório);
            this.Controls.Add(this.TreeMostra);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPlaySelec);
            this.Controls.Add(this.BtnDeleta2);
            this.Controls.Add(this.BtnDeleta);
            this.Controls.Add(this.BtnContinua);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.MenuArquivo);
            this.MainMenuStrip = this.MenuArquivo;
            this.Name = "FormLLMusic";
            this.Text = "LL Music ";
            this.MenuArquivo.ResumeLayout(false);
            this.MenuArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog OpenArq;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnContinua;
        private System.Windows.Forms.Button BtnDeleta;
        private System.Windows.Forms.Button BtnDeleta2;
        private System.Windows.Forms.Button BtnPlaySelec;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TreeView TreeMostra;
        private System.Windows.Forms.Button BtnAleatório;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnDeletaQlq;
    }
}


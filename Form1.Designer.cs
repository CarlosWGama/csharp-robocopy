namespace RoboCopyCWG2
{
    partial class MainForm
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
            this.btCopiar = new System.Windows.Forms.Button();
            this.folderBrowserOrigem = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxOrigem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDirOrigem = new System.Windows.Forms.Button();
            this.btDirDestino = new System.Windows.Forms.Button();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCopiar
            // 
            this.btCopiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btCopiar.Location = new System.Drawing.Point(13, 125);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(75, 23);
            this.btCopiar.TabIndex = 0;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.copiar);
            // 
            // textBoxOrigem
            // 
            this.textBoxOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrigem.Location = new System.Drawing.Point(12, 25);
            this.textBoxOrigem.Name = "textBoxOrigem";
            this.textBoxOrigem.Size = new System.Drawing.Size(411, 20);
            this.textBoxOrigem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diretorio Origem:";
            // 
            // btDirOrigem
            // 
            this.btDirOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDirOrigem.Location = new System.Drawing.Point(429, 22);
            this.btDirOrigem.Name = "btDirOrigem";
            this.btDirOrigem.Size = new System.Drawing.Size(75, 23);
            this.btDirOrigem.TabIndex = 3;
            this.btDirOrigem.Text = "Buscar";
            this.btDirOrigem.UseVisualStyleBackColor = true;
            this.btDirOrigem.Click += new System.EventHandler(this.buscarDiretorio);
            // 
            // btDirDestino
            // 
            this.btDirDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDirDestino.Location = new System.Drawing.Point(429, 88);
            this.btDirDestino.Name = "btDirDestino";
            this.btDirDestino.Size = new System.Drawing.Size(75, 23);
            this.btDirDestino.TabIndex = 4;
            this.btDirDestino.Text = "Buscar";
            this.btDirDestino.UseVisualStyleBackColor = true;
            this.btDirDestino.Click += new System.EventHandler(this.buscarDiretorio);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestino.Location = new System.Drawing.Point(13, 88);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(410, 20);
            this.textBoxDestino.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diretório Destino";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.btDirDestino);
            this.Controls.Add(this.btDirOrigem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrigem);
            this.Controls.Add(this.btCopiar);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RoboCopy CWG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserOrigem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDestino;
        private System.Windows.Forms.TextBox textBoxOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDirOrigem;
        private System.Windows.Forms.Button btDirDestino;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label label2;
    }
}


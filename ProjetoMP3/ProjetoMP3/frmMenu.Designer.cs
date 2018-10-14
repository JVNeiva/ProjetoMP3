namespace ProjetoMP3
{
    partial class frmMenu
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
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBarra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlBarra.Controls.Add(this.pbxMinimize);
            this.pnlBarra.Controls.Add(this.pbxClose);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(534, 29);
            this.pnlBarra.TabIndex = 0;
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireito.Location = new System.Drawing.Point(524, 29);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(10, 418);
            this.pnlDireito.TabIndex = 1;
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 29);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(10, 418);
            this.pnlEsquerdo.TabIndex = 2;
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBaixo.Location = new System.Drawing.Point(10, 437);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(514, 10);
            this.pnlBaixo.TabIndex = 3;
            // 
            // pnlCentro
            // 
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCentro.Location = new System.Drawing.Point(10, 56);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(514, 381);
            this.pnlCentro.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.musicasToolStripMenuItem,
            this.albunsToolStripMenuItem,
            this.playListsToolStripMenuItem,
            this.favoritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimize.Image = global::ProjetoMP3.Properties.Resources.icons8_minimizar_janela_32;
            this.pbxMinimize.Location = new System.Drawing.Point(477, 3);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(22, 22);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 1;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = global::ProjetoMP3.Properties.Resources.close_icone;
            this.pbxClose.Location = new System.Drawing.Point(502, 3);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(22, 22);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 0;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // musicasToolStripMenuItem
            // 
            this.musicasToolStripMenuItem.Name = "musicasToolStripMenuItem";
            this.musicasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.musicasToolStripMenuItem.Text = "Musicas";
            // 
            // albunsToolStripMenuItem
            // 
            this.albunsToolStripMenuItem.Name = "albunsToolStripMenuItem";
            this.albunsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.albunsToolStripMenuItem.Text = "Albuns";
            // 
            // playListsToolStripMenuItem
            // 
            this.playListsToolStripMenuItem.Name = "playListsToolStripMenuItem";
            this.playListsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.playListsToolStripMenuItem.Text = "Play Lists";
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlBaixo);
            this.Controls.Add(this.pnlEsquerdo);
            this.Controls.Add(this.pnlDireito);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBarra.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlBaixo;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}


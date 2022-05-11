namespace AppExemploMenu
{
    partial class Frm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frm1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm1ToolStripMenuItem
            // 
            this.frm1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrm1,
            this.exibirFrm2,
            this.exibirFrm3});
            this.frm1ToolStripMenuItem.Name = "frm1ToolStripMenuItem";
            this.frm1ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.frm1ToolStripMenuItem.Text = "Exibir";
            this.frm1ToolStripMenuItem.Click += new System.EventHandler(this.frm1ToolStripMenuItem_Click);
            // 
            // exibirFrm2
            // 
            this.exibirFrm2.Name = "exibirFrm2";
            this.exibirFrm2.Size = new System.Drawing.Size(180, 22);
            this.exibirFrm2.Text = "Frm2";
            this.exibirFrm2.Click += new System.EventHandler(this.exibirFrm2_Click);
            // 
            // exibirFrm3
            // 
            this.exibirFrm3.Name = "exibirFrm3";
            this.exibirFrm3.Size = new System.Drawing.Size(180, 22);
            this.exibirFrm3.Text = "Frm3";
            this.exibirFrm3.Click += new System.EventHandler(this.exibirFrm3_Click);
            // 
            // exibirFrm1
            // 
            this.exibirFrm1.Name = "exibirFrm1";
            this.exibirFrm1.Size = new System.Drawing.Size(180, 22);
            this.exibirFrm1.Text = "Frm1";
            this.exibirFrm1.Click += new System.EventHandler(this.exibirFrm1_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm2;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm3;
        private System.Windows.Forms.ToolStripMenuItem exibirFrm1;
    }
}


namespace mip_ödev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xkord = new System.Windows.Forms.TextBox();
            this.ykord = new System.Windows.Forms.TextBox();
            this.renkbox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "kapat";
            // 
            // renkalToolStripMenuItem
            // 
            this.renkalToolStripMenuItem.Name = "renkalToolStripMenuItem";
            this.renkalToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.renkalToolStripMenuItem.Text = "renkal";
            this.renkalToolStripMenuItem.Click += new System.EventHandler(this.renkalToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(16, 55);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(300, 300);
            this.kaynakbox.TabIndex = 2;
            this.kaynakbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xkord
            // 
            this.xkord.Location = new System.Drawing.Point(322, 371);
            this.xkord.Name = "xkord";
            this.xkord.Size = new System.Drawing.Size(97, 20);
            this.xkord.TabIndex = 3;
            // 
            // ykord
            // 
            this.ykord.Location = new System.Drawing.Point(322, 406);
            this.ykord.Name = "ykord";
            this.ykord.Size = new System.Drawing.Size(97, 20);
            this.ykord.TabIndex = 4;
            // 
            // renkbox
            // 
            this.renkbox.Location = new System.Drawing.Point(322, 55);
            this.renkbox.Name = "renkbox";
            this.renkbox.Size = new System.Drawing.Size(300, 300);
            this.renkbox.TabIndex = 5;
            this.renkbox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renkbox);
            this.Controls.Add(this.ykord);
            this.Controls.Add(this.xkord);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkalToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox xkord;
        private System.Windows.Forms.TextBox ykord;
        private System.Windows.Forms.PictureBox renkbox;
    }
}
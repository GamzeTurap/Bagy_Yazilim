namespace Bagy_Yazilim
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            katEkleToolStripMenuItem = new ToolStripMenuItem();
            masaEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            lstSiparis = new ListBox();
            lstToplam = new ListBox();
            btnÖde = new Button();
            flpKat = new FlowLayoutPanel();
            flpMasa = new FlowLayoutPanel();
            flpUrun = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { katEkleToolStripMenuItem, masaEkleToolStripMenuItem, ürünEkleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(769, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // katEkleToolStripMenuItem
            // 
            katEkleToolStripMenuItem.Name = "katEkleToolStripMenuItem";
            katEkleToolStripMenuItem.Size = new Size(60, 20);
            katEkleToolStripMenuItem.Text = "Kat Ekle";
            katEkleToolStripMenuItem.Click += katEkleToolStripMenuItem_Click;
            // 
            // masaEkleToolStripMenuItem
            // 
            masaEkleToolStripMenuItem.Name = "masaEkleToolStripMenuItem";
            masaEkleToolStripMenuItem.Size = new Size(71, 20);
            masaEkleToolStripMenuItem.Text = "Masa Ekle";
            masaEkleToolStripMenuItem.Click += masaEkleToolStripMenuItem_Click;
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(69, 20);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // lstSiparis
            // 
            lstSiparis.FormattingEnabled = true;
            lstSiparis.ItemHeight = 15;
            lstSiparis.Location = new Point(591, 22);
            lstSiparis.Name = "lstSiparis";
            lstSiparis.Size = new Size(166, 184);
            lstSiparis.TabIndex = 1;
            // 
            // lstToplam
            // 
            lstToplam.FormattingEnabled = true;
            lstToplam.ItemHeight = 15;
            lstToplam.Location = new Point(591, 212);
            lstToplam.Name = "lstToplam";
            lstToplam.Size = new Size(166, 49);
            lstToplam.TabIndex = 3;
            // 
            // btnÖde
            // 
            btnÖde.Location = new Point(682, 267);
            btnÖde.Name = "btnÖde";
            btnÖde.Size = new Size(75, 34);
            btnÖde.TabIndex = 4;
            btnÖde.Text = "Ödeme";
            btnÖde.UseVisualStyleBackColor = true;
            // 
            // flpKat
            // 
            flpKat.Location = new Point(0, 27);
            flpKat.Name = "flpKat";
            flpKat.Size = new Size(62, 264);
            flpKat.TabIndex = 5;
            // 
            // flpMasa
            // 
            flpMasa.Location = new Point(68, 27);
            flpMasa.Name = "flpMasa";
            flpMasa.Size = new Size(517, 75);
            flpMasa.TabIndex = 6;
            // 
            // flpUrun
            // 
            flpUrun.Location = new Point(68, 108);
            flpUrun.Name = "flpUrun";
            flpUrun.Size = new Size(517, 183);
            flpUrun.TabIndex = 7;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 387);
            Controls.Add(flpUrun);
            Controls.Add(flpMasa);
            Controls.Add(flpKat);
            Controls.Add(btnÖde);
            Controls.Add(lstToplam);
            Controls.Add(lstSiparis);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Giris";
            Text = "Form1";
            Load += Giris_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem katEkleToolStripMenuItem;
        private ToolStripMenuItem masaEkleToolStripMenuItem;
        private ListBox lstSiparis;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ListBox lstToplam;
        private Button btnÖde;
        private FlowLayoutPanel flpKat;
        private FlowLayoutPanel flpMasa;
        private FlowLayoutPanel flpUrun;
    }
}
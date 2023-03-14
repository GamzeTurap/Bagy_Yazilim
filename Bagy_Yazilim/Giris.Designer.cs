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
            lstSiparis = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { katEkleToolStripMenuItem, masaEkleToolStripMenuItem });
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
            // lstSiparis
            // 
            lstSiparis.FormattingEnabled = true;
            lstSiparis.ItemHeight = 15;
            lstSiparis.Location = new Point(591, 22);
            lstSiparis.Name = "lstSiparis";
            lstSiparis.Size = new Size(166, 229);
            lstSiparis.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(0, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(585, 212);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 387);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lstSiparis);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Giris";
            Text = "Form1";
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
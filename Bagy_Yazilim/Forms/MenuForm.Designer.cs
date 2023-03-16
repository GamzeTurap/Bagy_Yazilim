namespace Bagy_Yazilim.Class
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            btnUrunEkle = new Button();
            txtUrun = new TextBox();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            lstUrunList = new ListBox();
            picBoxFotograf = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            dosyaAc = new OpenFileDialog();
            dosyaKaydet = new SaveFileDialog();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFotograf).BeginInit();
            SuspendLayout();
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.RosyBrown;
            btnUrunEkle.Location = new Point(187, 234);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(75, 47);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(96, 47);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(166, 23);
            txtUrun.TabIndex = 1;
            // 
            // cmsSil
            // 
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // lstUrunList
            // 
            lstUrunList.FormattingEnabled = true;
            lstUrunList.ItemHeight = 15;
            lstUrunList.Location = new Point(287, 47);
            lstUrunList.Name = "lstUrunList";
            lstUrunList.Size = new Size(120, 184);
            lstUrunList.TabIndex = 3;
            lstUrunList.SelectedIndexChanged += lstUrunList_SelectedIndexChanged;
            // 
            // picBoxFotograf
            // 
            picBoxFotograf.Location = new Point(96, 148);
            picBoxFotograf.Name = "picBoxFotograf";
            picBoxFotograf.Size = new Size(108, 68);
            picBoxFotograf.TabIndex = 4;
            picBoxFotograf.TabStop = false;
            picBoxFotograf.Click += picBoxFotograf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOrange;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 98);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Fiyatı :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(96, 95);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(166, 23);
            txtFiyat.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkOrange;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 149);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "Fotoğraf :";
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "openFileDialog1";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Y_ld_zl_mavi_Nordic_seramik_tabak_servis_yuvarlak_tepsi_dekoratif_salata_su_i_tatl_taba;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(428, 332);
            Controls.Add(label3);
            Controls.Add(txtFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picBoxFotograf);
            Controls.Add(lstUrunList);
            Controls.Add(txtUrun);
            Controls.Add(btnUrunEkle);
            Name = "MenuForm";
            Text = "MenuForm";
            cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxFotograf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUrunEkle;
        private TextBox txtUrun;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private ListBox lstUrunList;
        private PictureBox picBoxFotograf;
        private Label label1;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private OpenFileDialog dosyaAc;
        private SaveFileDialog dosyaKaydet;
    }
}
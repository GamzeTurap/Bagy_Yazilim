﻿namespace Bagy_Yazilim.Forms
{
    partial class KatForm
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
            btnKatEkle = new Button();
            txtKat = new TextBox();
            lstKatlar = new ListBox();
            txtMasaSayisi = new TextBox();
            SuspendLayout();
            // 
            // btnKatEkle
            // 
            btnKatEkle.BackColor = Color.LightCoral;
            btnKatEkle.Location = new Point(234, 137);
            btnKatEkle.Name = "btnKatEkle";
            btnKatEkle.Size = new Size(74, 53);
            btnKatEkle.TabIndex = 0;
            btnKatEkle.Text = "Kat Ekle";
            btnKatEkle.UseVisualStyleBackColor = false;
            btnKatEkle.Click += btnKatEkle_Click;
            // 
            // txtKat
            // 
            txtKat.BackColor = Color.GreenYellow;
            txtKat.Location = new Point(154, 108);
            txtKat.Name = "txtKat";
            txtKat.Size = new Size(154, 23);
            txtKat.TabIndex = 1;
            // 
            // lstKatlar
            // 
            lstKatlar.FormattingEnabled = true;
            lstKatlar.ItemHeight = 15;
            lstKatlar.Location = new Point(358, 80);
            lstKatlar.Name = "lstKatlar";
            lstKatlar.Size = new Size(120, 199);
            lstKatlar.TabIndex = 4;
            // 
            // txtMasaSayisi
            // 
            txtMasaSayisi.Location = new Point(154, 222);
            txtMasaSayisi.Name = "txtMasaSayisi";
            txtMasaSayisi.Size = new Size(100, 23);
            txtMasaSayisi.TabIndex = 5;
            // 
            // KatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cafe_de_paris__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(490, 378);
            Controls.Add(txtMasaSayisi);
            Controls.Add(lstKatlar);
            Controls.Add(txtKat);
            Controls.Add(btnKatEkle);
            Name = "KatForm";
            Text = "KatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKatEkle;
        private TextBox txtKat;
        private ListBox lstKatlar;
        private TextBox txtMasaSayisi;
    }
}
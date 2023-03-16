namespace Bagy_Yazilim.Forms
{
    partial class MasaForm
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
            txtMasa = new TextBox();
            btnMasaEkle = new Button();
            flpMasalar = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtMasa
            // 
            txtMasa.Location = new Point(49, 54);
            txtMasa.Name = "txtMasa";
            txtMasa.Size = new Size(184, 23);
            txtMasa.TabIndex = 4;
            // 
            // btnMasaEkle
            // 
            btnMasaEkle.BackColor = SystemColors.ActiveCaption;
            btnMasaEkle.Location = new Point(326, 38);
            btnMasaEkle.Name = "btnMasaEkle";
            btnMasaEkle.Size = new Size(68, 53);
            btnMasaEkle.TabIndex = 3;
            btnMasaEkle.Text = "Masa Ekle";
            btnMasaEkle.UseVisualStyleBackColor = false;
            btnMasaEkle.Click += btnMasaEkle_Click;
            // 
            // flpMasalar
            // 
            flpMasalar.BackgroundImage = Properties.Resources.oze9010_2_560x560;
            flpMasalar.BackgroundImageLayout = ImageLayout.Stretch;
            flpMasalar.Location = new Point(-3, 97);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(422, 222);
            flpMasalar.TabIndex = 5;
            // 
            // MasaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.oze9010_2_560x560;
            ClientSize = new Size(416, 320);
            Controls.Add(flpMasalar);
            Controls.Add(txtMasa);
            Controls.Add(btnMasaEkle);
            Name = "MasaForm";
            Text = "MasaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMasa;
        private Button btnMasaEkle;
        private FlowLayoutPanel flpMasalar;
    }
}
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
            flpMasalar = new FlowLayoutPanel();
            txtMasa = new TextBox();
            btnMasaEkle = new Button();
            SuspendLayout();
            // 
            // flpMasalar
            // 
            flpMasalar.Location = new Point(56, 111);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(303, 144);
            flpMasalar.TabIndex = 5;
            // 
            // txtMasa
            // 
            txtMasa.Location = new Point(56, 54);
            txtMasa.Name = "txtMasa";
            txtMasa.Size = new Size(100, 23);
            txtMasa.TabIndex = 4;
            // 
            // btnMasaEkle
            // 
            btnMasaEkle.BackColor = SystemColors.ActiveCaption;
            btnMasaEkle.Location = new Point(223, 38);
            btnMasaEkle.Name = "btnMasaEkle";
            btnMasaEkle.Size = new Size(68, 53);
            btnMasaEkle.TabIndex = 3;
            btnMasaEkle.Text = "Masa Ekle";
            btnMasaEkle.UseVisualStyleBackColor = false;
            btnMasaEkle.Click += btnMasaEkle_Click;
            // 
            // MasaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 320);
            Controls.Add(flpMasalar);
            Controls.Add(txtMasa);
            Controls.Add(btnMasaEkle);
            Name = "MasaForm";
            Text = "MasaForm";
            Load += MasaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpMasalar;
        private TextBox txtMasa;
        private Button btnMasaEkle;
    }
}
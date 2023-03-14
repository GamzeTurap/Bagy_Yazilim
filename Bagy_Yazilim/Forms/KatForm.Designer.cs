namespace Bagy_Yazilim.Forms
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
            flpKatlar = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnKatEkle
            // 
            btnKatEkle.BackColor = SystemColors.ActiveCaption;
            btnKatEkle.Location = new Point(213, 39);
            btnKatEkle.Name = "btnKatEkle";
            btnKatEkle.Size = new Size(68, 53);
            btnKatEkle.TabIndex = 0;
            btnKatEkle.Text = "Kat Ekle";
            btnKatEkle.UseVisualStyleBackColor = false;
            btnKatEkle.Click += btnKatEkle_Click;
            // 
            // txtKat
            // 
            txtKat.Location = new Point(46, 55);
            txtKat.Name = "txtKat";
            txtKat.Size = new Size(100, 23);
            txtKat.TabIndex = 1;
            // 
            // flpKatlar
            // 
            flpKatlar.Location = new Point(46, 132);
            flpKatlar.Name = "flpKatlar";
            flpKatlar.Size = new Size(303, 144);
            flpKatlar.TabIndex = 2;
            // 
            // KatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 361);
            Controls.Add(flpKatlar);
            Controls.Add(txtKat);
            Controls.Add(btnKatEkle);
            Name = "KatForm";
            Text = "KatForm";
            Load += KatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKatEkle;
        private TextBox txtKat;
        private FlowLayoutPanel flpKatlar;
    }
}
using Bagy_Yazilim.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagy_Yazilim.Forms
{
    public partial class KatForm : Form
    {
        public KatForm()
        {
            InitializeComponent();
        }
       // public string girilenSayi;

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            Kat kat = new Kat();
            if (txtKat.Text != "")
            {
                kat.Ad = txtKat.Text;
                Button btn = new Button();
                btn.Text = kat.Ad;
                flpKatlar.Controls.Add(btn);
            }

            else
            {
                MessageBox.Show("Hata");

            }
        }

        private void KatForm_Load(object sender, EventArgs e)
        {

        }
    }
}

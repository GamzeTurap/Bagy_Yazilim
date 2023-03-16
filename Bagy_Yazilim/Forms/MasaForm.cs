using Bagy_Yazilim.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagy_Yazilim.Forms
{
    public partial class MasaForm : Form
    {
        public MasaForm()
        {
            InitializeComponent();
        }
        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa();
            masa.Ad = txtMasa.Text;
            Button btn = new Button();
            btn.Text = masa.Ad;
            flpMasalar.Controls.Add(btn);
        }
    }
}

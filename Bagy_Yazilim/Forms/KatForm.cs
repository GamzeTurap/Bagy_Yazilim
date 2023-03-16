using Bagy_Yazilim.Class;
using Bagy_Yazilim.Data;
using Bagy_Yazilim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagy_Yazilim.Forms;


public partial class KatForm : Form
{
    public EnvanterContext DataContext { get; set; }
    private List<Kat> _katlar = new List<Kat>();
    public KatForm()
    {
        InitializeComponent();
    } 
    private void KatForm_Load(object sender, EventArgs e)
    {
         lstKatlar.DataSource = DataContext.Katlar;

    }
    private void btnKatEkle_Click(object sender, EventArgs e)
    {
        Kat kat = new Kat();
        if (txtKat.Text != "")
        {
            Kat yeniKat = new Kat()
            {
                Ad = txtKat.Text

            };

            _katlar.Add(yeniKat);
            lstKatlar.DataSource = _katlar;
        }
    }
    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null) return;
        var seciliKat = lstKatlar.SelectedItem as Kat;
        DialogResult result = MessageBox.Show($"{seciliKat.Ad} .katı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            DataContext.Katlar.Remove(seciliKat);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = DataContext.Katlar;
            DataHelper.Save(DataContext);

        }
    }
}

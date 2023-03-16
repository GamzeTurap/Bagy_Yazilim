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
    public KatForm()
    {
        InitializeComponent();
    }
    // public string girilenSayi;

    private void btnKatEkle_Click(object sender, EventArgs e)
    {
        try
        {
            Kat kat = new Kat()
            {
                Ad = txtKat.Text,
                MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text)
            };
            DataContext.Katlar.Add(kat);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = DataContext.Katlar;
            for (int i = 1; i <= kat.MasaSayisi; i++)
            {
                Masa masa = new Masa()
                {
                    BulunduguKat = kat,
                    Ad = "Masa" + i.ToString()
                };
                DataContext.Masalar.Add(masa);
            }
            DataHelper.Save(DataContext);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
        }
    }
    private void KatForm_Load(object sender, EventArgs e)
    {
        // flpKatlar.DataSource = DataContext.Katlar;

    }

    private void btnKatKaydet_Click(object sender, EventArgs e)
    {

    }
}

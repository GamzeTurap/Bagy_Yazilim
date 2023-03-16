

using System.IO;

namespace Bagy_Yazilim.Class;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }
    private List<Urun> _urunler = new List<Urun>();
    private Urun? _seciliUrun;

    private MemoryStream _memoryStream = new MemoryStream();
    private int _bufferSize = 64;
    private byte[] _photoBytes = new byte[64];
    private void btnUrunEkle_Click(object sender, EventArgs e)
    {
        Urun urun = new Urun();
        if (txtUrun.Text != "")
        {
            Urun yeniUrun = new Urun()
            {
                Ad = txtUrun.Text,
                Fiyat = txtFiyat.Text

            };
            if (_memoryStream.Length > 0)
            {
                yeniUrun.Fotograf = _memoryStream.ToArray();
            }
            _memoryStream = new MemoryStream();
            _urunler.Add(yeniUrun);
            lstUrunList.DataSource = _urunler;
            //FormuTemizle();
        }
    }

    private void picBoxFotograf_Click(object sender, EventArgs e)
    {
        dosyaAc.Title = "Bir fotoğraf dosyası seçiniz";
        dosyaAc.Filter = "JPG Dosyaları (*.jpg)|*.jpg|PNG Dosyaları (*.png)|*.png";
        dosyaAc.FileName = string.Empty;
        dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (dosyaAc.ShowDialog() == DialogResult.OK)
        {
            _memoryStream = new MemoryStream();
            FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
            while (fileStream.Read(_photoBytes, 0, _bufferSize) != 0)
            {
                _memoryStream.Write(_photoBytes, 0, _bufferSize);
            }
            fileStream.Close();
            fileStream.Dispose();
            picBoxFotograf.Image = new Bitmap(_memoryStream);
        }
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstUrunList.SelectedItem == null) return;
        var _seciliUrun = lstUrunList.SelectedItem as Urun;

        DialogResult result = MessageBox.Show($"{_seciliUrun.Ad} ürünü silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _urunler.Remove(_seciliUrun);
            lstUrunList.DataSource = null;
            lstUrunList.DataSource = _urunler;
            //FormuTemizle();
        }
    }

    private void lstUrunList_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}


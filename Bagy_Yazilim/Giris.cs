using Bagy_Yazilim.Class;
using Bagy_Yazilim.Data;
using Bagy_Yazilim.Forms;
using Bagy_Yazilim.Helpers;

namespace Bagy_Yazilim
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private KatForm _katForm;
        private MasaForm _masaForm;
        private MenuForm _menuForm;
        private EnvanterContext _dataContext;

        private Urun? _seciliUrun;

        private void katEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_katForm == null)
            {
                _katForm = new KatForm();
                _katForm.Text = "Kat Formu";
                _katForm.DataContext = _dataContext;
                _katForm.Show();
            }
        }
        private void masaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_masaForm == null)
            {
                _masaForm = new MasaForm();
                _masaForm.Text = "Masa Formu";
                _masaForm.DataContext = _dataContext;
                _masaForm.Show();
            }
        }
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_menuForm == null)
            {
                _menuForm = new MenuForm();
                _menuForm.Text = "Masa Formu";
                _menuForm.DataContext = _dataContext;
                _menuForm.Show();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
             //var data = DataHelpers.Load();
             //_dataContext = data ?? new();
        }

    }
}
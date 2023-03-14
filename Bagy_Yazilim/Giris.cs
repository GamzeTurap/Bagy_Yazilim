using Bagy_Yazilim.Data;
using Bagy_Yazilim.Forms;

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
        private EnvanterContext _dataContext;


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


    }
}
using Bagy_Yazilim.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagy_Yazilim.Data
{
    public class EnvanterContext
    {
        public List<Kat> Katlar{ get; set; } = new List<Kat>();
        public List<Masa> Masalar { get; set; } = new List<Masa>();
        public List<Urun> Urunler { get; set; } = new List<Urun>();

       // public List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
    }
}

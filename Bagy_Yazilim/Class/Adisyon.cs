using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagy_Yazilim.Class
{
    internal class Adisyon
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public decimal ToplamFiyatHesapla()
        {
            decimal toplam = 0;
            foreach (var item in Urunler)
            {
                toplam += item.ToplamFiyat();
            }
            return toplam;
        }
    }
}

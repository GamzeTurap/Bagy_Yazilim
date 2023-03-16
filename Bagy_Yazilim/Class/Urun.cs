using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagy_Yazilim.Class;

public class Urun
{
    public string Ad { get; set; }
    public string Fiyat { get; set; }
    public byte[] Fotograf { get; set; }
    public override string ToString() => $"{this.Ad} {this.Fiyat}";
}

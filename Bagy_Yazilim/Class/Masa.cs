using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagy_Yazilim.Class;

public class Masa
{
    public string Ad { get; set; }
    public Kat BulunduguKat { get; set; }

    public override string ToString() => $"{this.Ad}";

}

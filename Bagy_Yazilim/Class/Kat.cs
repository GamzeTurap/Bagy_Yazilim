

namespace Bagy_Yazilim.Class;

public class Kat
{
    public string Ad { get; set; }
    public int KatSayisi { get; set; }
    public int MasaSayisi { get; set; }

    public override string ToString() => $"{this.Ad}" ;
    // public List<Masa> Masalar { get; set; } = new List<Masa>();
}

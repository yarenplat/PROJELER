namespace Kitapci;
public abstract class Urun
{
    private decimal _fiyat;
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat
    {
        get => _fiyat;
        set
        {
            if (value <= 0)
                throw new Exception("Fiyat 0'dan büyük olmalıdır");
            _fiyat = value;
        }
    }
    //protected sadece kalıtım verildiği sınıflar tarafından erişilebilir.
    public int Stok { get; protected set; } = 0;
    public byte[] Fotograf { get; set; }
    public double IndirimOrani { get; set; } = 0;
    public int SatisYap(int adet)
    {
        if (this.Stok >= adet)
            this.Stok -= adet;
        else
            throw new Exception("Stokta yeterli ürün yok");
        return this.Stok;
    }
    public int StokEkle(int adet)
    {
        this.Stok += adet;
        return this.Stok;
    }
}
public class Artist
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Ulke { get; set; }
    public string Cinsiyet { get; set; }
    public DateTime DogumTarihi { get; set; }
    public string DogumYeri { get; set; }
    public string Ozgecmis { get; set; }

    public List<Urun> Urunler { get; set; } = new List<Urun>();
}
public class Kitap : Urun
{
    public Artist Yazar{ get; set; }
    public int BasimYili { get; set; }
    public string YayinEvi { get; set; }
    public string ISBN { get; set; }
    public string Dil { get; set; }
}


public class Dergi : Urun
{
    public string YayinEvi { get; set; }
    public int Cilt { get; set; }
    public int Sayi { get; set; }
    public int BasimYili { get; set; }
    public string Dil { get; set; }
    public string ISBN { get; set; }
}
public class PlakCd : Urun
{
    public Artist Artist { get; set; } //Complex Type
    public string AlbumAdi { get; set; }
    public string Tur { get; set; }
}

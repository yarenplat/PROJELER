namespace RentACar.Lib;

public abstract class Tasıt
{
    private decimal _fiyat;
    public string Marka { get; set; }
    public string YakıtTuru { get; set; }
    public string Model { get; set; }
    public DateTime ModelYılı { get; set; }
    public int Km { get; set; }
    public string Renk { get; set; }

    public decimal Fiyat
    {
        get => _fiyat;
        set
        {
            if (_fiyat <= 0)
                throw new Exception("Fiyatı 0'dan büyük girilmelidir.");
            _fiyat = value;
        }
    }

    public int Stok { get; set; } = 0;
    public int Satıs(int adet)
    {
        if (this.Stok >= adet)
            this.Stok -= adet;
        else
            throw new Exception("Stokta yeterli ürün yok.");
        return this.Stok;
    }
    public int StokEkle(int adet)
    {
        this.Stok += adet;
        return this.Stok;
    }

}
////public class TasıtOzellikleri
////{
////    public string Marka { get; set; }
////    public string YakıtTuru { get; set; }
////    public string Model { get; set; }
////    public DateTime ModelYılı { get; set; }
////    public int Km { get; set; }
////    public string Renk { get; set; }

//}
public class Otomobil : Tasıt
{

    public string Marka { get; set; }
    public string YakıtTuru { get; set; }
}
public class Kamyon : Tasıt
{


}
public class Motosiklet : Tasıt
{

}
public class OtoMiniBus : Tasıt
{

}




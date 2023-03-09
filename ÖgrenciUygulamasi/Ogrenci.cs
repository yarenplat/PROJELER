namespace OgrenciUygulamasi;

public class Ogrenci
{
    public int ogrenciNo;
    private string isim;
    private string soyisim;
    private int vize1;
    private int vize2;
    private int final;
    private string okulİsmi;

    public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulİsmi)
    {
        ogrenciNo = _ogrenciNo;
        isim = _isim;
        soyisim = _soyisim;
        vize1 = _vize1;
        vize2 = _vize2;
        final = _final;
        okulİsmi = _okulİsmi;
    }
    public void ogrenciBilgileriGoster()
    {
        Console.WriteLine("Ögrenci Numarası:" + ogrenciNo);
        Console.WriteLine("Öğrenci İsmi:" + isim);
        Console.WriteLine("Öğrenci Soyismi:" + soyisim);
        Console.WriteLine("Öğrenci Birinci Vize Notu:" + vize1);
        Console.WriteLine("Öğrenci İkinic Vize Notu:" + vize2);
        Console.WriteLine("Öğrenci Final Notu:" + vize1);
        Console.WriteLine("Öğrenci Okul İsmi:" + okulİsmi);
    }
    public double ogrenciNotuBul()
    {
        double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
        return ortalama;
    }
    public void okulgetir()
    {
        Console.WriteLine("Okul İsmi:" + okulİsmi);
    }
}

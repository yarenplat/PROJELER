bool devamMi = true;
do
{
    string secimEkrani = $"1) Sayı Tahmin Oyunu\n2) Zar Tahmin Oyunu\n3) Sayıyı Metne Çevir\n4) Çıkış";
    Console.WriteLine(secimEkrani);
    ConsoleKey secim = Console.ReadKey().Key;
    switch (secim)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            SayiTahminOyunu();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            ZarTahminOyunu();
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            SayiyiMetneCevir();
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            //devamMi = false;
            devamMi = !devamMi;
            break;
    }
} while (devamMi);

Console.WriteLine("Program sonlandı.");

#region Methodlar
/// <summary>
/// Sayı tahmin oyununu başlatır
/// </summary>
void SayiTahminOyunu()
{
    Console.Clear();
    Console.WriteLine("Sayı tahmin oyunu başlıyor");
    int sayi = new Random().Next(1, 101);
    int tahminSayisi = 0;
    do
    {
        Console.WriteLine("0-100 arası bir sayı giriniz:");
        tahminSayisi++;
        try
        {
            int tahminEdilenSayi = int.Parse(Console.ReadLine());
            if (tahminEdilenSayi < 0 || tahminEdilenSayi > 100)
                throw new Exception("0-100 arası bir sayı giriniz.");
            if (tahminEdilenSayi < sayi)
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            else if (tahminEdilenSayi > sayi)
                Console.WriteLine("Daha küçük bir sayı giriniz.");
            else
            {
                Console.WriteLine($"Tebrikler, {tahminSayisi} adet denemede doğru tahmin ettiniz.");
                break;
            }
        }
        catch
        {
            Console.WriteLine("Yanlış bir giriş yaptınız");
        }
    } while (true);
}

void ZarTahminOyunu()
{
    Console.Clear();
    Console.WriteLine("Zar tahmin oyunu başlıyor");
    int tahminSayisi = 0, girilenSayi = SayiGirdirici(1, 6, "1-6 arası bir sayı giriniz");
    Random rnd = new();
    do // oyun döngüsü
    {
        int zar1 = rnd.Next(1, 7), zar2 = rnd.Next(1, 7);
        tahminSayisi++;
        Console.WriteLine($"{tahminSayisi:00}) {zar1} - {zar2}");
        if (zar1 == zar2 && zar1 == girilenSayi)
        {
            Console.WriteLine($"Tebrikler, {tahminSayisi} adet denemede istenen zar bulundu.");
            break;
        }
    } while (true);
}

void SayiyiMetneCevir()
{
    Console.Clear();
    Console.WriteLine("Sayıyı metne çevirme oyunu başlıyor");
    string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
    string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
    string[] yuzler = { "", "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
    string[] binler = { "", "Bin", "İkiBin", "ÜçBin", "DörtBin", "BeşBin", "AltıBin", "YediBin", "SekizBin", "DokuzBin" };
    string[] milyonlar = { "", "BirMilyon", "İkiMilyon", "ÜçMilyon", "DörtMilyon", "BeşMilyon", "AltıMilyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
    int girilenSayi = SayiGirdirici(0, 9999999, "0-9999999 arası bir sayı giriniz");

    if (girilenSayi == 0)
    {
        Console.WriteLine("Sıfır");
        return;
    }

    int basamak1 = girilenSayi % 10;
    int basamak10 = girilenSayi / 10 % 10;
    int basamak100 = girilenSayi / 100 % 10;
    int basamak1000 = girilenSayi / 1000 % 10;
    int basamak10000 = girilenSayi / 10000 % 10;
    int basamak100000 = girilenSayi / 100000 % 10;
    int basamak1000000 = girilenSayi / 1000000 % 10;
    string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";
    Console.WriteLine(okunus);
}

int SayiGirdirici(int baslangic, int bitis, string mesaj, string hataMesaji = "Yanlış bir giriş yaptınız")
{
    do
    {
        try
        {
            Console.WriteLine(mesaj);
            int girilenSayi = int.Parse(Console.ReadLine());
            if (girilenSayi < baslangic || girilenSayi > bitis)
                throw new Exception();
            return girilenSayi;
        }
        catch
        {
            Console.WriteLine(hataMesaji);
        }
    } while (true);
}
#endregion

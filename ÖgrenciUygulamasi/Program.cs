namespace OgrenciUygulamasi;

public class Program
{
    static void Main(string[] args)
    {
        bool kontrol = true;

        Ogrenci ogrenci1 = new Ogrenci(14, "Yaren", "Polat", 90, 90, 90, "GKAL");

        while (kontrol)
        {
            İslemleriGöster();
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    ogrenci1.ogrenciBilgileriGoster();
                    break;

                case "2":
                    double ogrenciOrtalaması = ogrenci1.ogrenciNotuBul();
                    Console.WriteLine("Öğrenci Ortalaması" + ogrenciOrtalaması);
                    break;

                case "3":
                    ogrenci1.okulgetir();
                    break;
                case "4":
                    kontrol = false;
                    break;

            }
        }

    }




    static void İslemleriGöster()
    {
        Console.WriteLine("1-Öğrenci Bilgilerini Göster");
        Console.WriteLine("2-Öğrenci Ortalamasını Göster");
        Console.WriteLine("3-Öğrenci Okul Adını Göster");
        Console.WriteLine("4-Çıkış");


    }

}


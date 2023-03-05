/*Hata Yönetimi
 * 1)Kullanıcı giriş işlemlerinde
 * 2)Dosya işlemlerinde
 * 3)Ağ işlemlerinde
 * 3)Veritabanı işlemlerinde
 * 4)Matematiksel işlemlerde
 * 6)Programın çalışma zamanında oluşabilecek hatalarda kullanılmalıdır.
 * */

Console.WriteLine("0 ile 10 ararsında bir sayı giriniz");
int hak = 3;

do
{
	try
	{
		int girilenSayi=Convert.ToInt32(Console.ReadLine());
		if (girilenSayi<0||girilenSayi>10)
		{
			throw new Exception("girilen sayı 0 ile 10 arasında olmalıdır");
		}
		Console.WriteLine($"girdiğiniz sayı:{girilenSayi}");
		break;

	}
	catch (Exception ex)
	{

		Console.WriteLine(ex.Message);
		hak--;

	}
	finally//bu blok her durumda çalışır. Hata olsa da olmsa da
	{
		Console.WriteLine("işlem tamamlandı");
	}
} while (hak>0);
if(hak>0)
	Console.WriteLine("aferin başarabildin");
else
	Console.WriteLine("başaramadın");

Console.WriteLine("bir sayı daha girin");
string giris=Console.ReadLine();
if(int.TryParse(giris,out int sayi))
{
	Console.WriteLine("girdiğiniz sayı:"+sayi);
}
else
{
	Console.WriteLine("sayı girmeyi beceremedin");
}
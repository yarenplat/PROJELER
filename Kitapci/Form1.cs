using Kitapci;

namespace Kitapci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Urun> Urunler = new List<Urun>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap();
            yeniKitap.Ad = "C# 9 ve .NET 5";
            yeniKitap.Aciklama = "C# 9 ve .NET 5 ile ilgili bilgiler";
            yeniKitap.BasimYili = 2022;
            yeniKitap.Fiyat = 100;
            yeniKitap.ISBN = "123456789";

            Artist yazar = new Artist();
            yazar.Ad = "Ahmet";
            yazar.Soyad = "Yýlmaz";
            yazar.DogumTarihi = new DateTime(1980, 1, 1);

            yeniKitap.Yazar = yazar;

            //yazar.Urunler = new List<Urun>() { yeniKitap };
            yazar.Urunler.Add(yeniKitap);

            Urunler.Add(yeniKitap);
            Console.WriteLine();
        }
    }
}
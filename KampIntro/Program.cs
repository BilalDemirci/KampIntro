namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 300;
            double faizOrani = 1.44;
            bool girisYapmisMi = true;
            double dolarDun = 7.44;
            double dolarBugun = 31.75;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azaldı Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Arttı Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (girisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(KategoriEtiketi);
        }
    }
}

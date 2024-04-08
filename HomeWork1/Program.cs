namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Süt";
            urun1.Fiyat = 44;
            urun1.Stok = 45;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Cips";
            urun2.Fiyat = 13;
            urun2.Stok = 16;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Krem";
            urun3.Fiyat = 23;
            urun3.Stok = 33;

            Urun[] urunler = new Urun[] 
            { 
                urun1,urun2,urun3
            };

            
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " - " + urunler[i].Fiyat + " TL");
            }
            Console.WriteLine("---------------------------------");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " - " + urun.Fiyat + " TL ");
            }
            Console.WriteLine("---------------------------------");

            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + " - " + urunler[j].Fiyat + " TL");
                j++;
            }


            Console.ReadLine();
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
    }
}

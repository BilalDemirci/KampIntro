namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Gece Lambası";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Hüsonun lambası";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Saat";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Akıllı Kol Saati";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " - " + urun.Fiyati + " TL");
            }

            Console.WriteLine("----------------------METHODS------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);




            Console.ReadLine();
        }
    }
}

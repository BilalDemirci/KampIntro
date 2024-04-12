namespace DictionaryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Bilal Demirci");
            kullanicilar.Add(2, "Burak Demirci");
            kullanicilar.Add(3, "Rabia Demirci");
            kullanicilar.Add(4, "İsa Demirci");
            kullanicilar.Add(5, "Aybüke Genç");
            kullanicilar.Add(6, "Barney Barney");


            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici);
            }

            string yeniKullkanici = "Hüseyin Ali Çakar";
            bool varMi = kullanicilar.TryGetValue(1, out yeniKullkanici);

            if (varMi)
            {
                Console.WriteLine("BU ID ile kayıtlı bir kullanıcı mevcut");
            }else
            {
                kullanicilar.Add(0, yeniKullkanici);
                Console.WriteLine("Kullanıcı ekleme işlemi başarıyla gerçekleşti!");
            }

            Console.ReadLine();
        }
    }
}

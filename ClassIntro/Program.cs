namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Bilal";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Bilal Demirci";
            kurs1.IzlenmeOrani = 44;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Jquery";
            kurs2.Egitmen = "Aybüke Genç";
            kurs2.IzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Burak Demirci";
            kurs3.IzlenmeOrani = 94;

            Console.WriteLine("---------------------------------");

            //Console.WriteLine(kurs1.KursAdi + " - " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2, kurs3,
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen + " - " + kurs.IzlenmeOrani);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

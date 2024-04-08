namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gerlitirici kampı";
            string kurs2 = "Kurs2";
            string kurs3 = "kurs3";

            string[] kurslar = new string[]
            {
                "kurs1","kurs2","kurs3","kurs4","kurs5","kurs6 "
            };
            

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}

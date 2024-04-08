namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Bilal");
            isimler.Add("Burak");
            isimler.Add("Rabia");
            isimler.Add("İsa");




            Console.ReadLine();
        }
    }
}

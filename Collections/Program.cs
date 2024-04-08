namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Bilal","Aybüke","Burak","Rabia","İsa"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[0]);

            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //isimler = new string[6];
            //isimler[5] = "Barney";

            List<string> isimler2 = new List<string> {"Bilal","Burak","Rabia","İsa"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Aybüke");
            isimler2.Add("Barney");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
            


            Console.ReadLine();
        }
    }
}

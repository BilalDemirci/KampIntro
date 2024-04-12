namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] {10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);
            Console.WriteLine("-----------------");


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Bilal";
            person2 = person1;
            person1.FirstName = "Aybüke";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.CreditCardNumber = "12345";
            Person person3 = customer;
            customer.FirstName = "Burak";
            Employee employee = new Employee();
            employee.FirstName = "Rabia";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);



            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " Eklendi");
        }
    }
    
}

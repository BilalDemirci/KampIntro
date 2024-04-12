
using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.IdentityNumber = "45654";
customer1.CustomerNumber = 1234;
customer1.FirstName = "Bilal";
customer1.LastName = "Demirci";

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = 45;
customer2.TaxNumber = "213124";
customer2.CompanyName = "TeknoBBD";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);


Console.ReadLine();
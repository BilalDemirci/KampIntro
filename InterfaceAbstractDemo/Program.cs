
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer
{
    DateOfBirth = new DateTime(1999,3,25),
    FirstName = "Bilal",
    LastName = "Demirci",
     NationalityId = "61075121328"
});

Console.ReadLine();


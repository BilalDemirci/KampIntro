
using OOP3;

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
ICreditManager vehicleCreditManager = new VehicleCreditManager();
ICreditManager housingCreditManager = new HousingCreditManager();
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeApplication(personalFinanceCreditManager, fileLoggerService);
Console.WriteLine("--------------------------------------");
applicationManager.MakeApplication(housingCreditManager,databaseLoggerService);
Console.WriteLine("--------------------------------------");
applicationManager.MakeApplication(vehicleCreditManager,databaseLoggerService);

List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,vehicleCreditManager};
//applicationManager.KrediOnBilgilendirmesiYap(credits);

Console.ReadLine();
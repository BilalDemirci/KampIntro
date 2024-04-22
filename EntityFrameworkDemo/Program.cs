
using EntityFrameworkDemo;

//GetAll();
GetProductsByCategory(1);

Console.ReadLine();

static void GetAll()
{
    NorthwindContext northwindContext = new NorthwindContext();
    foreach (var product in northwindContext.Products)
    {
        Console.WriteLine(product.ProductName);
    }
}

static void GetProductsByCategory(int categoryId)
{
    NorthwindContext northwindContext = new NorthwindContext();

    var result = northwindContext.Products.Where(p=>p.CategoryId == categoryId);

    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}
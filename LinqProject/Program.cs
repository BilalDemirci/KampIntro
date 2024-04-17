
List<Category> categories = new List<Category>
{
    new Category{CategoryId=1, CategoryName="Bilgisayar"},
    new Category{CategoryId=2, CategoryName="Telefon"},
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=25000, UnitInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=15000, UnitInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=1000, UnitInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000, UnitInStock=15},
    new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=7500, UnitInStock=0},

};

Console.WriteLine("ALGORİTMİK --------------------------------------");

foreach (Product product in products)
{
    if (product.UnitPrice > 7500 && product.UnitInStock>3)
    {
        Console.WriteLine(product.ProductName);
    }
}

Console.WriteLine("LİNQ --------------------------------------------");
var result = products.Where(p => p.UnitPrice >= 5000 && p.UnitInStock > 2);
foreach (Product product in result)
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("--------------------------------------");

GetProducts(products);

Console.WriteLine("--------------------------------------");

GetProductsLinq(products);

Console.ReadLine();

static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();
    foreach (Product product in products)
    {
        if (product.UnitPrice > 7500 && product.UnitInStock > 3)
        {
            filteredProducts.Add(product);
        }
    }
    return filteredProducts;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice >= 5000 && p.UnitInStock > 2).ToList();
}


class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
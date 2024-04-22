
List<Category> categories = new List<Category>
{
    new Category{CategoryId=1, CategoryName="Bilgisayar"},
    new Category{CategoryId=2, CategoryName="Telefon"},
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=25000, UnitInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=15000, UnitInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=10000, UnitInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000, UnitInStock=15},
    new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=7500, UnitInStock=0},

};

//Test(products);
//Console.WriteLine("--------------------------------------");

//GetProducts(products);
//Console.WriteLine("--------------------------------------");

//GetProductsLinq(products);
//AnyTest(products);
//FindTest(products);
//FindAllTest(products);
//AscDescTest(products);
//ClassicLinqTest(products);

var result = from p in products
             join c in categories
             on p.CategoryId equals c.CategoryId
             where p.UnitPrice>5000
             orderby p.UnitPrice descending
             select new ProductDto {ProductId = p.ProductId,CategoryName=c.CategoryName, ProductName=p.ProductName,UnitPrice=p.UnitPrice};

foreach (var productDto in result)
{
    Console.WriteLine("{0} --- {1}", productDto.ProductName,productDto.CategoryName);
}


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

static void Test(List<Product> products)
{
    Console.WriteLine("ALGORİTMİK --------------------------------------");

    foreach (Product product in products)
    {
        if (product.UnitPrice > 7500 && product.UnitInStock > 3)
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
}

static void AnyTest(List<Product> products)
{
    var result = products.Any(p => p.ProductName == "Dell Laptop");
    Console.WriteLine(result);
}

static void FindTest(List<Product> products)
{
    var result = products.Find(p => p.ProductId == 4);
    Console.WriteLine(result);
    Console.WriteLine(result.ProductName);
}

static void FindAllTest(List<Product> products)
{
    var result = products.FindAll(p => p.ProductName.Contains("top"));
    Console.WriteLine(result);
}

static void AscDescTest(List<Product> products)
{
    var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);

    foreach (Product product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}

//static void ClassicLinqTest(List<Product> products)
//{
//    var result = from p in products
//                 where p.UnitPrice > 6000
//                 orderby p.UnitPrice descending, p.ProductName ascending
//                 select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
//    foreach (Product product in result)
//    {
//        Console.WriteLine(product.ProductName);
//    }
//}

class ProductDto
{
    public int ProductId { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
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
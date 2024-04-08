namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Kalem",
                UnitPrice = 85,
                UnitsInStock = 45     
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Update(product2);




            Console.ReadLine();
        }
    }
}

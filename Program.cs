using Task9_2.Data;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            // 1- Retrieve all categories from the production.categories table.

            //var catcategorie = dbContext.Categories;
            //foreach (var item in catcategorie)
            //{
            //    Console.WriteLine($"CategoryId: {item.CategoryId},CategoryName: {item.CategoryName}");
            //}

            // 2- Retrieve the first product from the production.products table.

            //var product = dbContext.Products.Where(p=>p.ProductId == 1);
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"ProductId: {item.ProductId}, ProductName: {item.ProductName}, brandId:{item.BrandId}," +
            //        $"CategoryId: {item.CategoryId}, ModelYear: {item.ModelYear}, ListPrice: {item.ListPrice} ");
            //}

            // Anthor Method

            //var product = dbContext.Products .SingleOrDefault(e=>e.ProductId == 1);
            //if (product != null)
            //{
            //Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, brandId:{product.BrandId}," +
            //   $"CategoryId: {product.CategoryId}, ModelYear: {product.ModelYear}, ListPrice: {product.ListPrice} ");
            //}
            //else
            //{
            //    Console.WriteLine(" Error!!");
            //}

            // 3- Retrieve a specific product from the production.products table by ID.

            //var product = dbContext.Products.FirstOrDefault(e => e.ProductId == 5);
            //if (product != null)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, brandId:{product.BrandId}," +
            //      $"CategoryId: {product.CategoryId}, ModelYear: {product.ModelYear}, ListPrice: {product.ListPrice} ");
            //}
            //else
            //{
            //    Console.WriteLine(" Error!!");
            //}

            // 4- Retrieve all products from the production.products table with a certain model year.

            //var product = dbContext.Products.Where(e => e.ModelYear == 2016);
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"ProductId: {item.ProductId}, ProductName: {item.ProductName}, brandId:{item.BrandId}," +
            //        $"CategoryId: {item.CategoryId}, ModelYear: {item.ModelYear}, ListPrice: {item.ListPrice} ");
            //}

            // 5- Retrieve a specific customer from the sales.customers table by ID.
            //var customer = dbContext.Customers.Skip(3).Take(1);
            //foreach (var item in customer)
            //{
            //    Console.WriteLine($"CustomerId: {item.CustomerId}, CustomerName: {item.FirstName + ' ' + item.LastName}, Phone:{item.Phone}," +
            //        $"Email: {item.Email}, Street: {item.Street}, City: {item.City}, State: {item.State}, Zip_Code: {item.ZipCode} ");
            //}

            // 6- Retrieve a list of product names and their corresponding brand names
            //var product = dbContext.Products.Include(p => p.Brand).Select(p => new
            //{
            //    ProductName = p.ProductName,
            //    BrandName = p.Brand.BrandName
            //}).ToList();
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"ProductName: {item.ProductName}, BrandName: {item.BrandName} ");
            //}


            // 7- Count the number of products in a specific category.
            //int categoryid = 2;
            //var product = dbContext.Products.Where(e => e.CategoryId == categoryid).Count();
            //Console.WriteLine($"the number of products in category has id {categoryid} = {product}");

            // 8- Calculate the total list price of all products in a specific category.
            //int categoryid = 4;
            //var product = dbContext.Products.Where(e=>e.CategoryId == categoryid).Sum(e=>e.ListPrice);
            //Console.WriteLine($"the number of products in category has id {categoryid} = {product} $");

            // 9- Calculate the average list price of products.

            //var product = dbContext.Products.Average(e=>e.ListPrice);
            //Console.WriteLine($" the average list price of products = {product} $");

            // 10- Retrieve orders that are completed.

            //var order = dbContext.Orders.Where(e => e.OrderStatus == 4).Select(e => new
            //{
            //    OrderId = e.OrderId,
            //    CustomerId = e.CustomerId,
            //    OrderStatus = e.OrderStatus,
            //    OrderDate = e.OrderDate,
            //    requiredDate = e.RequiredDate,
            //});
            //foreach (var item in order)
            //{
            //    Console.WriteLine($"orderId: {item.OrderId}, CustomerId: {item.CustomerId}, OrderStatus: {item.OrderStatus}, " +
            //        $"OrderDate: {item.OrderDate}, requiredDate: {item.requiredDate}");
            //}
        }
    }
}

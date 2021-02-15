using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            NortwindContext northwind = new NortwindContext();
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("ProductId" + "\t" + "ProductName" + "\t\t" + "CategoryName " + "\t" + "UnıtInStock" + "\t" + "UnıtsPrice");
            Console.WriteLine(" ");


            foreach (var product in productManager.GetProductDetail())

            {
                
               
                Console.WriteLine(product.ProductId + "\t\t" + product.ProductName + "\t\t" + product.CategoryName + "\t\t" + product.UnitsInStock + "\t\t" + product.UnitsPrice);
            }

        }
    }
}

using ClasWork.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasWork
{
    internal class Program : Product
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product { Id = 0, Name = "toko", Price = 55 });
            list.Add(new Product { Id = 1, Name = "saba", Price = 15 });
            list.Add(new Product { Id = 2, Name = "luka", Price = 50 });
            list.Add(new Product { Id = 3, Name = "nino", Price = 14 });
            list.Add(new Product { Id = 4, Name = "vano", Price = 35 });

            foreach (var product in list)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            Console.WriteLine("###########################################");
            
            IEnumerable<Product> filteredData =
                list.Where(product => product.Price > 35);

            foreach (var product in filteredData)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            Console.WriteLine("###########################################");

            foreach (var product in list)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            var distinctList = list.Distinct(new ProductComparer()).ToList();

            Console.WriteLine("###########################################");

            foreach (var product in distinctList)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}

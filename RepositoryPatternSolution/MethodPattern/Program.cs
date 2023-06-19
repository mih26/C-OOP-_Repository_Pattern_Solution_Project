using MethodPattern.Models;
using MethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGenericRepo<Product> repo;
            RepoFactory factory = new RepoFactory();
            repo = factory.Get<Product>();
            repo.Add(new Product
            {
                Id = 1,
                Name = "P1",
                Price = 950.00M
            });
            repo.Add(new Product
            {
                Id = 2,
                Name = "P2",
                Price = 950.00M
            });
            repo.Add(new Product
            {
                Id = 3,
                Name = "P3",
                Price = 950.00M
            });
            Console.WriteLine("Product list");
            foreach (var p in repo.Get())
            {
                Console.WriteLine($"{p.Name} {p.Price}");

            }
            Console.WriteLine("Updating one item");
            repo.Update(x => x.Id == 2, new Product
            {
                Id = 2,
                Name = "P2",
                Price = 750.00M
            });
            foreach (var p in repo.Get())
            {
                Console.WriteLine($"{p.Name} {p.Price}");

            }
            Console.WriteLine("Deleting one item");
            repo.Delete(x => x.Id == 2);
            foreach (var p in repo.Get())
            {
                Console.WriteLine($"{p.Name} {p.Price}");

            }
            Console.WriteLine("-------------------------");
            IGenericRepo<Customer> repoCust;
            repoCust = factory.Create<Customer>();
            
            repoCust.Add(new Customer { Id = 101, Name = "Customer 1", Address = "Mirpur, Dhaka", Phone = "01710XXXXXX" });
            repoCust.Add(new Customer { Id = 102, Name = "Customer 2", Address = "Gulshan, Dhaka", Phone = "01810XXXXXX" });
            repoCust.Add(new Customer { Id = 103, Name = "Customer 3", Address = "Uttara, Dhaka", Phone = "01927XXXXXX" });
            Console.WriteLine("Customer list");
            repoCust.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Id} {x.Name} {x.Address} {x.Phone}"));
            Console.WriteLine("Updating one item");
            repoCust.Update(x => x.Id == 102, new Customer { Id = 102, Name = "Customer 2", Address = "Dhanmondi, Dhaka", Phone = "01674XXXXXX" });
            repoCust.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Id} {x.Name} {x.Address} {x.Phone}"));
            Console.WriteLine("Deleting one item");
            repoCust.Delete(x => x.Id == 103);
            repoCust.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Id} {x.Name} {x.Address} {x.Phone}"));
            Console.ReadKey();
        }
    }
}

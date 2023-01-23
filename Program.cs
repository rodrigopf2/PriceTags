using System;
using System.Collections.Generic;
using System.Globalization;
using price_tags.Entities;

namespace price_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i)");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String Name = Console.ReadLine();
                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    list.Add(new Product(Name, Price));
                }

                
                

            }
        }
    }
}

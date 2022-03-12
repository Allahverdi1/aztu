using System;
 
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Jaket ",
                BrandName = "Lc Waikiki",
                Price = 40
            };
 
            Console.WriteLine($"{product1.Name} {product1.BrandName}  {product1.Price}");
 
            Product product2 = new Product
            {
                Name = "Koynek",
                BrandName = "Zara",
                Price = 35
            };
 
            Console.WriteLine($"{product2.Name} {product2.BrandName}  {product2.Price}");
 
            Product product3 = new Product
            {
                Name = "Ayaqqabi",
                BrandName = "Flo",
                Price = 70
            };
 
            Console.WriteLine($"{product3.Name} {product3.BrandName}  {product3.Price}");
 
            Product product4 = new Product
            {
            Name = "Salvar",
            BrandName = "Pull Bear",
            Price = 55
            };
 
            Console.WriteLine($"{product4.Name} {product4.BrandName}  {product4.Price}");
 
 
            Product product5 = new Product();
 
            product5.Name = "Salvar";
            product5.BrandName= "Vasmoy Bazari";
            product5.Price = 15;
            Console.WriteLine($"{product5.Name} {product5.BrandName}  {product5.Price}");
 
           
        }
 
 
 
 
    }
    class Product
    {
        public string Name;
        public string BrandName;
        public int Price;
    }
}




        





  


         
    






using System;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine(str);
            var result = str.Split(" ");
            Console.WriteLine(result[0]);
            Console.WriteLine(str.StartsWith("H"));
            Console.WriteLine(result[1]);
            Console.WriteLine(str.StartsWith("W"));
            

          
            
        }
    }
}

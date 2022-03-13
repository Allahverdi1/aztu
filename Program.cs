using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lengthStr;
            int length;
            do
            {
                Console.WriteLine("Zehmet olmasa Book sayini daxil edin:");
                lengthStr = Console.ReadLine();
                length = Convert.ToInt32(lengthStr);

            } while (length < 0);
            Book[] books = new Book[length];
            for (int i = 0; i < length; i++)
            {
                string countStr;
                int count;

                do
                {
                    Console.WriteLine($"{ i + 1}.Book-un zehmet olmasa sayini daxil edin");
                    countStr = Console.ReadLine();
                    count = Convert.ToInt32(countStr);

                } while (count < 0);

                string priceStr;
                double price;

                do
                {
                    Console.WriteLine($"{ i + 1}.Book-un zehmet olmasa qiymetini daxil edin");
                    priceStr = Console.ReadLine();
                    price = Convert.ToDouble(priceStr);
                }
                while (price < 0);

                string Name;

                do
                {
                    Console.WriteLine($"{ i + 1}.Book-un zehmet olmasa Adini daxil edin");
                    Name = Console.ReadLine();

                } while (Name.Length < 0);

                string Genre;

                do
                {
                    Console.WriteLine($"{ i + 1}.Book-un zehmet olmasa Janrini daxil edin");
                    Genre = Console.ReadLine();

                } while (Genre.Length < 0);

                string noStr;
                int no;

                do
                {
                    Console.WriteLine($"{ i + 1}.Book-un zehmet olmasa Nomresini daxil edin");
                    noStr = Console.ReadLine();
                    no = Convert.ToInt32(noStr);

                } while (no < 0);










                }
        }
    }

    


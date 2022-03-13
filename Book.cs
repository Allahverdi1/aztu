using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Book:Product
    {
        public Book(int No, string Name, double Price, string Genre) : base(No, Name, Price)
        {
            this.Genre = Genre;
        }
        public string Genre;
    }
}

    


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        static int _no;
        public int No { get; }

        public Book()
        {
            _no++;
            No = _no;

        }
    }
}

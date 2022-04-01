using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Library
    {
        List <Book> books = new List <Book> ();
        public void FindAllBooksByName(string value)
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                
            }
        }
        public void RemoveAllBookByName(string str)
        {
            foreach (Book book in books)
            {
                
            }
        }

        public void FindAllBooksByPageCountRange(int min,int max)
        {

        }

        public void RemoveByCode(int value)
        {
            
        }






    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;

        public int StudentLimit
        {
            get => this._studentLimit;
            set
            {
                if (value > 0)
                    this._studentLimit = value;
            }
        }
        public string No
        {
            get => this._no;
            set
            {
                if (CheckNo(value))
                    this._no = value;
            }
        }
        public bool HasDigit(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 2; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            }

            return false;
        }
        public bool HasUpper(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        return true;
                }
            }

            return false;
        }
    }
}






        
        

        
    

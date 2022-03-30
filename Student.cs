using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Student
    {
        public string FullName { get; set; }
        static int _no;
        public int No { get; }
        private string _student { get; set; }
        public Student(string v)
        {
            _no++;
            this.No = _no;

        }
    }
}

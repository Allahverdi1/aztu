using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    enum GroupType
    { 
        Programming,
        Desing,
        System
    }

    internal class Group
    {
        static int _no;
        public int No { get; }
        public Student[] _student;
        private Student[] _students;
        public GroupType type { get; set; }
         
        

        

        public Group()
        {
            this._students = new Student[0];
        }
        public Student[] Students { get => _students; }
        public void AddStudent(Student student)
        {
            if (type is Student)
            {
                Array.Resize(ref this._students, this._students.Length + 1);
                this._students[this._students.Length - 1] = student;
            }
        }

        public static implicit operator Group(Student v)
        {
            throw new NotImplementedException();
        }
    }
}

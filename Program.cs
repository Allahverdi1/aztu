using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("telebe1");
            Student student2 = new Student("telebe2");
            Student student3 = new Student("telebe3");

            Group group = student1;
            int[] nums = { };

            try
            {
                Console.WriteLine("GroupName daxil et");
                string groupName = Console.ReadLine();

                if (groupName != null && !char.IsUpper(groupName[0])) 
                throw new GroupNameIsWrongException("GroupName boyuk herfle bashlamalidir");

                nums[1] = 100;
               
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class StudentList
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> studentList = new Dictionary<int, string>();
                Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                string buff = Console.ReadLine();
                studentList.Add(rnd.Next(0, 1000), buff);
            }

            foreach (var item in studentList)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}

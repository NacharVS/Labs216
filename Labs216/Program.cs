using System;
using System.Collections.Generic;
using System.Text;

using Labs216.Nabiullina;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            Group student1 = new Group("Ivan", "Loginov");
            student1.Name = "vasiliy";
            Console.WriteLine($" {student1.Name} {student1.Surname}");
            

            
        }
    }
}

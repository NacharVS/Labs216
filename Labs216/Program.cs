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
            Group[] group = new Group[5];
            group[0] = new Group("Zina", "Galinganova");
            group[1] = new Group("azamat", "Colovejov");
            group[2] = new Group("Fedor", "Cafronov");
            group[3] = new Group("maria", "Gabutdinov");
            group[4] = new Group("alesya", "Zajchuk");
            
            Console.WriteLine(group[0]._name[0] = group[0]._name[0].ToString().ToUpper());
            Console.WriteLine(group[1]._name[0].ToString().ToUpper());
            Console.WriteLine(group[2]._name[0].ToString().ToUpper());
            Console.WriteLine(group[3]._name[0].ToString().ToUpper());
            Console.WriteLine(group[4]._name[0].ToString().ToUpper());

            LetterFix.LetterFix1(group);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Labs216.Delegates;
using Labs216.Nabiullina;
using Labs216.Nabiullina.StrategyGame;

namespace Labs216
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("David", "Petrova"));
            personList.Add(new Person("Nick", "Stepanov"));
            personList.Add(new Person("Vadim", "Karmanov"));
            personList.Add(new Person("Anton", "Stolov"));
            personList.Add(new Person("Firuza", "Salamalekym"));
            personList.Add(new Person("Alsy", "Ololova"));

            foreach (var item in personList)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
                Console.WriteLine(" Хотите что-нибудь поменять? 1-да / 2-нет ");
                int a = int.Parse (Console.ReadLine());
                if (a == 1)
                {

                }
                if (a == 2)
                {

                }
            }
            
        }

    }
}

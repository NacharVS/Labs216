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
            personList.Add(new Person("David", "Petrova", new DateTime(2000, 5,8), "89898923412" , "Dava2000"));
            personList.Add(new Person("Nick", "Stepanov", new DateTime(2005, 6, 12), "89196811863", "Nick2005"));
            personList.Add(new Person("Vadim", "Karmanov", new DateTime(2007, 6, 19), "89041741090", "Vadim2007"));
            personList.Add(new Person("Anton", "Stolov", new DateTime(2010, 5, 8), "98193652412", "Anton2010"));
            personList.Add(new Person("Firuza", "Salamalekym", new DateTime(2012, 3, 24), "89324569851", "Firuza"));
            personList.Add(new Person("Alsy", "Ololova", new DateTime(2003, 5, 14), "89047141055", "Alsy2003"));

            foreach (var item in personList)
            {
                Console.WriteLine($"{item.Name} {item.Surname}  Age: {item.Date} phone number: {item.Telephon} ");
                
            }
            Console.WriteLine(" Хотите что-нибудь поменять? 1-да / 2-нет ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                
            }
            if (a == 2)
            {

            }
        }

    }
}

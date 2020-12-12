using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class Slovar_
    {
        public static void Slovarik()
        {
            Dictionary<int, Person> personList = new Dictionary<int, Person>();

            personList.Add(1, new Person("Anton", "Petrovich"));
            personList.Add(2, new Person("Alisa", "Cyclik"));
            personList.Add(3, new Person("Liza", "Medvedeva"));
            personList.Add(4, new Person("Misha", "Medvedev"));
            personList.Add(5, new Person("Masha", "Samoilova"));
            personList.Add(6, new Person("Petya", "Goroxov"));
            personList.Add(7, new Person("Vasya", "Pupkin"));
            personList.Add(8, new Person("Nikita", "Nitochkin"));
            personList.Add(9, new Person("Nina", "Kyrochkina"));
            personList.Add(10, new Person("Jake", "Prinsev"));

            foreach (var item in personList)
            {
                Console.WriteLine(item.Key + " " + item.Value.Name + " " + item.Value.Surname);
            }

        }
    }
}

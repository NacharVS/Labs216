using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216
{
    class Accounts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Accounts(int id, string name, string surname, int age)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    class EditingAccount
    {
        public static void Editing()
        {
            List<Accounts> accList = new List<Accounts>();
            accList.Add(new Accounts(1, "Nurlan", "Saburov", 27));
            accList.Add(new Accounts(2, "Azamat", "Musagaliev", 35));
            accList.Add(new Accounts(3, "Aleksey", "Cherbakov", 30));
            accList.Add(new Accounts(4, "Rustam", "Reptiloid", 25));
            accList.Add(new Accounts(5, "Tambi", "Masaev", 25));

            

            foreach (var item in accList)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Surname} {item.Age}");
            }
            Console.WriteLine();

            EditingName(accList, 4, "Artur");
            EditingAge(accList, 1, 30);
            EditingSurname(accList, 2, "Aliev");
            
            foreach (var item in accList)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Surname} {item.Age}");
            }
        }
        public static void EditingName(List<Accounts> list, int selected, string newName)
        {
            foreach (var item in list)
            {
                if (item.ID == selected)
                {
                    item.Name = newName;
                }
            }
        }
        public static void EditingAge(List<Accounts> list, int selected, int newAge)
        {
            foreach(var item in list)
            {
                if (item.ID == selected)
                {
                    item.Age = newAge;
                }
            }
        }
        public static void EditingSurname(List<Accounts> list, int selected, string newSurname)
        {
            foreach (var item in list)
            {
                if (item.ID == selected)
                {
                    item.Surname = newSurname;
                }
            }
        }
    }
}

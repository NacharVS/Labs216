using System;
using System.Collections.Generic;
using Labs216.Gabdulkhaev;

namespace Labs216
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bank> Banklist = new List<Bank>();
            Banklist.Add(new Bank("Имя1", "Фамилия1", 20, 1, new DateTime(2000, 1, 1)));
            Banklist.Add(new Bank("Имя2", "Фамилия2", 25, 2, new DateTime(1995, 1, 2)));
            Banklist.Add(new Bank("Имя3", "Фамилия3", 26, 3, new DateTime(1994, 1, 3)));
            Banklist.Add(new Bank("Имя4", "Фамилия4", 19, 4, new DateTime(2001, 1, 4)));
            Banklist.Add(new Bank("Имя5", "Фамилия5", 5, 5, new DateTime(2015, 1, 5)));
            Banklist.Add(new Bank("Имя6", "Фамилия6", 15, 6, new DateTime(2005, 1, 6)));
            Banklist.Add(new Bank("Имя7", "Фамилия7", 50, 7, new DateTime(1970, 1, 7)));
            Banklist.Add(new Bank("Имя8", "Фамилия8", 38, 8, new DateTime(1982, 1, 8)));
            Banklist.Add(new Bank("Имя9", "Фамилия9", 68, 9, new DateTime(1952, 1, 9)));
            Banklist.Add(new Bank("Имя10", "Фамилия10", 99, 10, new DateTime(1921, 1, 10)));
            Banklist.Add(new Bank("Имя11", "Фамилия11", 120, 11, new DateTime(1900, 1, 11)));
            ChangeName(Banklist, 1, "Имя12");
            ChangeAge(Banklist, 3, 96);
            ChangeID(Banklist, 10, 20);
            ChangeSurname(Banklist, 5, "Фамилия20");
            foreach (var item in Banklist)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        static void ChangeName(List<Bank> List, int naitiId, string NewName)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Name = NewName;
            }
        }
        static void ChangeSurname(List<Bank> List, int naitiId, string NewFam)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Surname = NewFam;
            }
        }
        static void ChangeID(List<Bank> List, int naitiId, int NewID)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Id = NewID;
            }
        }
        static void ChangeAge(List<Bank> List, int naitiId, int NewAge)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Age = NewAge;
            }
            //  static void ChangeAge1(Dictionary<int,Bank>bankList, int searchId, string newAge)
            // {
            //          bankList[searchId].SetAge(newAge);
            //    }
        }
    }
}

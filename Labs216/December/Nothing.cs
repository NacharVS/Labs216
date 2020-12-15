using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.December
{
    class ChtoBuloDalshe
    {
        public string Name;
        public string Surname;
        public int Age;

        public ChtoBuloDalshe(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    class Nothing
    {
        public static void Working()
        {
            ObservableCollection<ChtoBuloDalshe> comic = new ObservableCollection<ChtoBuloDalshe>();
            comic.Add(new ChtoBuloDalshe("Nurlan", "Saburov", 27));
            comic.Add(new ChtoBuloDalshe("Aleksey", "Cherbakov", 30));
            comic.Add(new ChtoBuloDalshe("Tambi", "Masaev", 25));
            comic.Add(new ChtoBuloDalshe("Rustam", "Reptiloid", 25));
            comic.CollectionChanged += ComicCollectionChanged;
            comic.Add(new ChtoBuloDalshe("Artur", "Chaparyan", 28));
            comic.RemoveAt(1);
            foreach (var item in comic)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Age}");
            }
        }
        public static void ComicCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Console.WriteLine("Something added");
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        Console.WriteLine("Something removed");
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    {
                        Console.WriteLine("Something replaced");
                    }
                    break;
            }
        }
    }
    
}

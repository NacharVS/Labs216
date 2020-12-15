using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.Nabiullina
{
    class ObservableCollection1111
    {
        public string _name;
        public int _age;

        public ObservableCollection1111(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public static void Observable()
        {
            ObservableCollection <ObservableCollection1111> student = new ObservableCollection <ObservableCollection1111>
            {
                new ObservableCollection1111("Rayshan", 22),
                new ObservableCollection1111("Marysiya", 25)
            };
            student.CollectionChanged += Student_CollectionChanged;
            student.Add(new ObservableCollection1111("Marsel", 19));
            student.Add(new ObservableCollection1111("Arina", 28));
            student.Remove(new ObservableCollection1111("Olol", 19));
            student.Remove(new ObservableCollection1111("Piypiy", 27));
            student[1] = new ObservableCollection1111("Camira", 17);
            

        }

        static void Student_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Something added");
            }

            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Something removed");
            }

            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Something replace");
            }
        }
    }
}
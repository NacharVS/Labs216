using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.MirasovEG
{
    class Student
    {
        public string _name { get; private set; }
        public int _age { get; private set; }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }



    class Nikak
    {
        public static void Collection()
        {
            ObservableCollection <Student> students = new ObservableCollection<Student>();

            students.CollectionChanged += Students_CollectionChanged;
            students.Add(new Student("Vlad", 18));
            students.Add(new Student("Rom", 27));
            students.Move(0, 1);
            students.Remove(new Student("Roma", 15));
            students.RemoveAt(1);
            students.Insert(1, new Student("Vika", 20));

        }

        private static void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                Console.WriteLine("Something added");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Something Remove");
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Something Replace");
                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Something Move");
                    break;

            }
        }
    }

}

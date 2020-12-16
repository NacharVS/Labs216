using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Labs216.Shakirov;

namespace ConsoleApplication1
{
    class Student
    {
        public string Name { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { Name = "letwik" },
                new Student { Name = "fwexy" },
                new Student { Name = "jamside" },
            };

            students.CollectionChanged += Student_CollectionChanged;

            students.Add(new Student { Name = "7ssk7" });

            students.RemoveAt(1);

            students[0] = new Student { Name = "hurma" };

            foreach (Student user in students)
            {
                Console.WriteLine(user.Name);
            }

            Console.Read();
        }

        private static void Student_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Student newStudent = e.NewItems[0] as Student;
                    Console.WriteLine($"new s.: {newStudent.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Student oldStudent = e.OldItems[0] as Student;
                    Console.WriteLine($"dobavlen ob.: {oldStudent.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Student replacedUser = e.OldItems[0] as Student;
                    Student replacingUser = e.NewItems[0] as Student;
                    Console.WriteLine($"ob. {replacedUser.Name} zamena ob. {replacingUser.Name}");
                    break;
            }
        }
    }

    class Name
    {
        public string Student { get; set; }
    }
}
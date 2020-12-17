using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.Dmitriev
{
    class ObservableCollection
    {
        static void Main(string[] args)
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { Name = "Serega"},
                new Student { Name = "Iskander"},
                new Student { Name = "Maksim"}
            };

            students.CollectionChanged += Users_CollectionChanged;

            students.Add(new Student { Name = "Timur" });
            students.RemoveAt(1);
            students[0] = new Student { Name = "Aynur" };

            foreach (Student user in students)
            {
                Console.WriteLine(user.Name);
            }

            Console.Read();
        }

        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Student newStudent = e.NewItems[0] as Student;
                    Console.WriteLine($"dobavlen ob.: {newStudent.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Student oldStudent = e.OldItems[0] as Student;
                    Console.WriteLine($"dobavlen ob.: {oldStudent.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Student replacedStudent = e.OldItems[0] as Student;
                    Student replacingStudent = e.NewItems[0] as Student;
                    Console.WriteLine($"ob. {replacedStudent.Name} zamena ob. {replacingStudent.Name}");
                    break;
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
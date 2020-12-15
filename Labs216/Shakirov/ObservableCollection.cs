using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reflection.Metadata;

namespace ConsoleApplication1
{
    class Student
    {
        public string Name { get; set; }
    }

    class Program
    {

        static void Main (string[] args)
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
        }
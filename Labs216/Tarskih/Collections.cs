using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Labs216.Tarskih
{
    class ObservalCollectionsActions
    {
        static void Main(string[] args)
        {
            ObservableCollection<Subject> subjects = new ObservableCollection<Subject>
            {
                new Subject { Name = "DJ Vasya"},
                new Subject { Name = "Pivasik"},
                new Subject { Name = "Parketniy Pol"}
            };

            subjects.CollectionChanged += Subjects_CollectionChanged;

            subjects.Add(new Subject { Name = "Adskiy Bober" });
            subjects.RemoveAt(1);
            subjects[0] = new Subject { Name = "CyberZhaba" };

            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject.Name);
            }

            Console.Read();
        }

        private static void Subjects_CollectionChanged(object otpravitel, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Subject newSubject = e.NewItems[0] as Subject;
                    Console.WriteLine($"Добавлен субъект: {newSubject.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Subject oldSubject = e.OldItems[0] as Subject;
                    Console.WriteLine($"Удален субъект: {oldSubject.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Subject replacedSubject = e.OldItems[0] as Subject;
                    Subject replacingSubject = e.NewItems[0] as Subject;
                    Console.WriteLine($"Субъект {replacedSubject.Name} заменен субъектом {replacingSubject.Name}");
                    break;
            }
        }
    }

    class Subject
    {
        public string Name { get; set; }
    }
}

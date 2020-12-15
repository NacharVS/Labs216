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
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User { Name = "Serega"},
                new User { Name = "Iskander"},
                new User { Name = "Maksim"}
            };

            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User { Name = "Timur" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Aynur" };

            foreach (User user in users)
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
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine($"dobavlen ob.: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine($"dobavlen ob.: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: 
                    User replacedUser = e.OldItems[0] as User;
                    User replacingUser = e.NewItems[0] as User;
                    Console.WriteLine($"ob. {replacedUser.Name} zamena ob. {replacingUser.Name}");
                    break;
            }
        }
    }

    class User
    {
        public string Name { get; set; }
    }
}
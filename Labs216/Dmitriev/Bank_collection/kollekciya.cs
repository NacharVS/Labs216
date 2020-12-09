using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev.Bank_collection
{
    abstract class Klient
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get => _name;
            set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public string Surname
        {
            get => _surname;
            set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
        }

        public virtual void GetInform()
        {
            Console.WriteLine($"li4nostb klienta: {Name}{Surname}");
        }
        abstract class Klient
        {
            private string _name;
            private string _surname;

            public string Name
            {
                get => _name;
                set => _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }

            public string Surname
            {
                get => _surname;
                set => _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }

            public virtual void GetInform()
            {
                Console.WriteLine($"Your name: {Name}{Surname}");
            }
        }
    }
}

namespace _216Labs2020.Faskhutdinov.Bank_class
{
    class Bank
    {
        public Bank()
        {
            
       
          
        }
            
        class BankPerson
        {
            public static string Name { get; set; }
            public BankPerson(string name)
            {
                Name = name;
            }
        }
        class User : BankPerson
        {
            public int Sum { get; set; }

            public User(string name, int sum)
                : base(name)
            {
                Sum = sum;
            }
        }
        class Worker : BankPerson
        {
            public string Position { get; set; }

            public Worker(string name, string position)
                : base(name)
            {
                Position = position;
            }
        }

    }
}
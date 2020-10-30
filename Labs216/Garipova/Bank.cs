using System;

namespace Labs216.Garipova
{ 
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 9;
        private static int count = 0;
        private static int _MaxTake = 10000;
        private static int _MinPut = 1000;
       private int _year { get; set; }
        private int _month { get; set; }

            public void Getinfo()
        {
            Console.WriteLine($"Вас зовут:{_name} {_surname }");
            Console.WriteLine($"Ваш id :{_id }");
            Console.WriteLine($"{_rate }");
        }
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
        }
        public void Setsurname(string newsurname)
        {
            newsurname = newsurname.Trim();
            var Letter = newsurname[0];
            var Lettter = newsurname.Remove(0, 1);
            _surname = (Letter.ToString().ToUpper() + Lettter);
        }
            public string Id(string newId)
            {
                _id = _name + _surname + count;
                count += 1;
                return _id;
            }



        public static void Start()
        {
                Bank bank = new Bank();
                Console.WriteLine("");
                bank._name = Console.ReadLine();
                Console.WriteLine("");
                bank._surname  = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("");
                bank._year = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                bank._month = int.Parse(Console.ReadLine());

                int now = DateTime.Now.Year;
                int month = DateTime.Now._month;

                if (now - bank._year >= 14 && month > bank._month)
                {
                    Console.WriteLine("Access is allowed");

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("");
                                double with = double.Parse(Console.ReadLine());
                                if (_rate > with)
                                {
                                    Console.WriteLine("-");
                                }
                                else
                                {
                                    Console.WriteLine($"{_rate -= with} money");
                                }
                                else
                                {
                                    Console.WriteLine("{_rate} money");
                                }
                            case "2":
                                Console.WriteLine("Minput 1000");
                                double put = double.Parse(Console.ReadLine());
                                if (put > 1000)
                                {
                                    Console.WriteLine("-");
                                }
                                else { Console.WriteLine($"{_rate += put} money"); }
                                break;

                        }


            }

    }
}

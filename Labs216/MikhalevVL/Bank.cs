using System;

namespace Labs216.MikhalevVL
{
    class Bank
    {
        private string name;
        private string id;
        private string surname;
        private static int rate = 5;
        private double bank_account;
        private static string[] account_array = new string[1000];
        private static string[] passwords = new string[1000];
        private static double[] money_array = new double[1000];
        private static int min = 1000;
        private static int max = 10000000;
        private static int count = 0;

        public string Name_public
        {
            get => name;
            set => name = $"{value[0].ToString().ToUpper() + value.Substring(1).ToLower()}";
        }

        public string Surname_public
        {
            get => surname;
            set => surname = $"{value[0].ToString().ToUpper() + value.Substring(1).ToLower()}";
        }

        public void GenerationID()
        {
            id = Name_public + Surname_public + count;
            for (int i = 0; i < account_array.Length; i++)
            {
                if (account_array[i] == id)
                {
                    count += 1;
                    id = Name_public + Surname_public + count;
                }
            }
            for (int i = 0; i < account_array.Length; i++)
            {
                if (account_array[i] == null)
                {
                    account_array[i] = id;
                    break;
                }
            }
        }

        public static void StartBank()
        {
            var leavesign = 1;
            while (leavesign == 1)
            {
                Bank bank = new Bank();
                Console.WriteLine("What do you want to do? \n 1 - Signup \n 2 - Signin");
                int choisesign = int.Parse(Console.ReadLine());
                switch (choisesign)
                {
                    case 1:
                        bank.Signup();
                        break;
                    case 2:
                        bank.Signin();
                        break;
                }

                var isthisend = 0;
                while (isthisend == 0)
                {
                    Console.WriteLine("What do you want to do? \n 1 - Put money into the account \n 2 - Withdraw money from an account \n 3 - Calculate how much money will be on the account in a few years \n 4 - Leave");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            bank.Put();
                            break;

                        case 2:
                            bank.Take();
                            break;

                        case 3:
                            bank.Calculate();
                            break;
                        case 4:
                            isthisend = 1;
                            break;
                    }
                    Console.WriteLine("Do you want to continue (Y/N)");
                    string a = Console.ReadLine();
                    if (a == "N" || a == "n")
                    {
                        isthisend = 1;
                    }
                }
            }

        }
        public void Signup()
        {
            Bank bank = new Bank();

            Console.WriteLine("Enter Name:");
            bank.Name_public = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            bank.Surname_public = Console.ReadLine();

            bank.GenerationID();
            Console.WriteLine($"Your ID: {bank.id}");

            Console.WriteLine("Enter your password:");
            string pass = Console.ReadLine();
            for (int i = 0; i < passwords.Length; i++)
            {
                if (passwords[i] == null)
                {
                    passwords[i] = pass;
                    break;
                }
            }
        }
        public void Signin()
        {
            var leave = 1;
            while (leave == 1)
            {
                Bank bank = new Bank();
                Console.WriteLine("Enter your id:");
                string userid = Console.ReadLine();
                string right_password;
                double money;
                var check = 0;
                for (int i = 0; i < account_array.Length; i++)
                {
                    if (account_array[i].Contains(userid))
                    {
                        right_password = passwords[i];
                        bank.bank_account = money_array[i];
                        check = 1;
                        var truepass = 1;
                        while (truepass == 1)
                        {
                            Console.WriteLine("Enter your password (or leave): ");
                            string user_pass = Console.ReadLine();
                            if (right_password.Contains(user_pass))
                            {
                                leave = 1;
                                Console.WriteLine("Confirm");
                            }
                            else if (user_pass == "leave")
                            {
                                leave = 0;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect password");
                            }
                        }
                    }
                }
                if (check == 0)
                {
                    Console.WriteLine("Your account was not found");
                }
            }
        }

        public void Put()
        {

            Console.WriteLine("How much do you want to deposit");
            int value = int.Parse(Console.ReadLine());

            if (value < min)
            {
                Console.WriteLine($"You cannot deposit less, than minimum: ({min})");
            }
            else
            {
                bank_account += value;
            }

            Console.WriteLine($"Money on your account: {bank_account}");
        }
        public void Take()
        {

            Console.WriteLine("How much do you want to take from your account");
            int value = int.Parse(Console.ReadLine());

            if (value > bank_account)
            {
                Console.WriteLine($"You cannot take greatier than your account ({bank_account})");
            }
            if (value > max)
            {
                Console.WriteLine($"You cannot take greatier than max ({max})");
            }
            Console.WriteLine($"On your account: { bank_account}");
            Console.WriteLine();
        }

        public void Calculate()
        {
            if (bank_account == 0)
            {
                Console.WriteLine("First you need to deposit money to your account");
            }
            else
            {
                Console.WriteLine("How many years to calculate a Bank account");
                int year = int.Parse(Console.ReadLine());
                double yearly = 0;
                double check_acc = bank_account;
                for (int i = 0; i < year; i++)
                {
                    double one_percent = check_acc / 100;
                    yearly = one_percent * rate;
                    check_acc += yearly;
                }

                Console.WriteLine($"{check_acc} will be on your acount in {year} years");
            }
            Console.WriteLine();

        }
    }
}

using System;

namespace Labs216.MikhalevVL
{
    class Bank
    {
        public static void bank()
        {
            string[] account_array = null;
            string[] name_surname_array = null;
            string[] stavka_array = null;
            int isthisend = 1;
            while (isthisend == 1)
            {

                Console.WriteLine("What do you want to do? (1.Check Bank Account; 2.Add Bank Account; 3.Leave");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    for (int i = 0; i < account_array.Length; i++)
                    {
                        if (account_array != null)
                        {
                            Console.WriteLine($"{i}. {account_array[i]} {name_surname_array[i]} {stavka_array[i]}");
                        }
                        else Console.WriteLine("There is no Bank accounts");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter your name and surname:");
                    string name_surname = Console.ReadLine();
                    Console.WriteLine("Enter your interest rate:");
                    string stavka = Console.ReadLine();
                    string account_id = name_surname.Replace(" ", "");
                    for (int i = 0; i < name_surname_array.Length; i++)
                    {
                        for (int j = 0; j < int.MaxValue; j++)
                        {
                            if (account_array[i].Contains(account_id))
                            {
                                account_id = account_id + "j";
                            }
                        }
                    }
                    account_array[] + account_id;
                    Console.WriteLine($"Your id: {account_id}");
                }
                else if (choice == 3)
                {
                    isthisend = 0;
                    Console.Clear();
                    Console.WriteLine("Thank you. Goodbye");
                }
                else Console.WriteLine("Error");
            }
        }
    }
}

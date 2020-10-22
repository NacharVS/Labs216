using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class Class4chek // Класс содержащий методы для работы с классами, которые содержат приватные элементы
    {
        public static void Bank()
        {
            Bank[] acc = new Bank[3];
            for (int i = 0; i < 3; i++)
            {
                acc[i] = new Bank();
            }
            for (int i = 0; i < 3; i++) // Это выврд для проверки правильно ли создааеться база данных и выбора с каким аккаунтом работать
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
            }
            Console.WriteLine("Which account do you want to work with");
            int acc_number = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("What do you want: 1 -- Withdraw money || 2 -- Deposit money || 3 -- Check account || 4 -- Calculate deposit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How much:");
                        acc[acc_number].Withdraw(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("How much:");
                        acc[acc_number].Deposit(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(acc[acc_number].Account);
                        break;
                    case 4:
                        Console.WriteLine("How many years to calculate");
                        acc[acc_number].Calculate(int.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("Continue y/n");
                if (Console.ReadLine() == "n")
                    break;
            }
            for (int i = 0; i < 3; i++) // Это вывод для проверки правильно ли програма работала с данными
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Money--{acc[i].Account}");
            }
        }
    }
}

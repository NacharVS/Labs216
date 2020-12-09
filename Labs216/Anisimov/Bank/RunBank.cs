using System;

namespace Labs216.Anisimov.Bank
{
    class RunBank
    {
        public static void Run()
        {
            Bank bank = new Bank();

            bool alive = true;
            while (alive)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Открыть счет \t 2. Вывести средства  \t 3. Добавить на счет");
                Console.WriteLine("4. Купить \t 5. Изменить процентную ставку \t 6. Закрыть счет");
                Console.WriteLine("7. Подождать \t 8.Посмотреть информацию \t 9. Отредактировать данные");
                Console.WriteLine("10. Выйти из программы");
                Console.WriteLine("Введите номер пункта:");
                Console.ForegroundColor = tmp;

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            OpenAccount(bank);
                            break;
                        case "2":
                            Withdraw(bank);
                            break;
                        case "3":
                            Put(bank);
                            break;
                        case "4":
                            Buy(bank);
                            break;
                        case "5":
                            ChangeRate(bank);
                            break;
                        case "6":
                            CloseAccount(bank);
                            break;
                        case "7":
                            Wait(bank);
                            break;
                        case "8":
                            GetInfo(bank);
                            break;
                        case "9":
                            EditInfo(bank);
                            break;
                        case "10":
                            alive = false;
                            continue;
                    }
                }
                catch(Exception exeprion)
                {
                    ConsoleColor temp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exeprion.Message);
                    Console.ForegroundColor = temp;
                }
            }
        }

        private static void OpenAccount(Bank bank)
        {
            Console.WriteLine("Укажите имя, фамилию, телефон и дату рождения(dd.mm.yyyy)");
            string[] data = Console.ReadLine().Split(" ");
            if (data.Length != 4)
                throw new Exception("Wrong input");
            bank.Open(data[0], data[1], data[2], data[3]);
        }
        private static void Withdraw(Bank bank)
        {
            Console.WriteLine("Укажите сумму для вывода со счета:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите id счета:");
            int id = int.Parse(Console.ReadLine());

            bank.Withdraw(sum, id);
        }
        private static void Put(Bank bank)
        {
            Console.WriteLine("Укажите сумму, чтобы положить на счет:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Id счета:");
            int id = int.Parse(Console.ReadLine());

            bank.Put(sum, id);
        }
        private static void CloseAccount(Bank bank)
        {
            Console.WriteLine("Введите id счета, который надо закрыть:");
            int id = int.Parse(Console.ReadLine());

            bank.Close(id);
        }
        private static void Buy(Bank bank)
        {
            Console.WriteLine("Укажите сумму покупки:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите id счета:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите организацию в которой покупали");
            string organization = Console.ReadLine();

            bank.Buy(sum, id, organization);
        }
        private static void ChangeRate(Bank bank)
        {
            Console.WriteLine("Укажите новое значение");
            double newRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите id счета:");
            int id = int.Parse(Console.ReadLine());

            bank.ChangeRate(id, newRate);
        }
        private static void Wait(Bank bank)
        {
            Console.WriteLine("Сколько дней вы хотите ждать");

            bank.SkipTime(int.Parse(Console.ReadLine()));
        }
        private static void EditInfo(Bank bank)
        {
            Console.WriteLine("Введите id счета:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Какую информацию вы хотите изменить\n1. Имя\t2. Фамилию\t3.Номер телефона\t4.Дату рождения");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение");

            bank.EditInfo(id, choose, Console.ReadLine());
        }
        private static void GetInfo(Bank bank)
        {
            Console.WriteLine("Введите id счета:");
            int id = int.Parse(Console.ReadLine());

            bank.GetInfo(id);
        }
    }
}

using System;
using System.Threading;

namespace Labs216.Anisimov.Bank
{
    class RunBank
    {
        private static bool alive = true;

        public static void Run()
        {
            Bank bank = new Bank();
            Thread LiveTime = new Thread(new ParameterizedThreadStart(ThreadWait));
            //LiveTime.Start(bank);

            while (alive)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Открыть счет \t 2. Вывести средства  \t 3. Внести средства\n" +
                    "4. Купить \t 5. Изменить процентную ставку \t 6. Закрыть счет\n" +
                    "7. Подождать \t 8. Вывести список аккаунтов \t 9. Отредактировать данные\n" +
                    "10.Найти аккаунт \t 11. Остановить время \t 12. Возобновить время\n" +
                    "13. Выйти из программы");
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
                            GetList(bank);
                            break;
                        case "9":
                            EditInfo(bank);
                            break;
                        case "10":
                            Search(bank);
                            break;
                        case "11":
                            FreezeThread(LiveTime);
                            break;
                        case "12":
                            ResumeThread(LiveTime);
                            break;
                        case "13":
                            {
                                alive = false;
                            }
                            continue;
                    }
                }
                catch(Exception exeption)
                {
                    ConsoleColor temp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exeption.Message);
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
            string id = Console.ReadLine();

            bank.Withdraw(sum, id);
        }
        private static void Put(Bank bank)
        {
            Console.WriteLine("Укажите сумму, чтобы положить на счет:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Id счета:");
            string id = Console.ReadLine();

            bank.Put(sum, id);
        }
        private static void CloseAccount(Bank bank)
        {
            Console.WriteLine("Введите id счета, который надо закрыть:");
            string id = Console.ReadLine();

            bank.Close(id);
        }
        private static void Buy(Bank bank)
        {
            Console.WriteLine("Укажите сумму покупки:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите id счета:");
            string id = Console.ReadLine();
            Console.WriteLine("Укажите организацию в которой покупали");
            string organization = Console.ReadLine();

            bank.Buy(sum, id, organization);
        }
        private static void ChangeRate(Bank bank)
        {
            Console.WriteLine("Укажите новое значение");
            double newRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите id счета:");
            string id = Console.ReadLine();

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
            string id = Console.ReadLine();
            bank.GetInfo(id);
            Console.WriteLine("Какую информацию вы хотите изменить\n1. Имя\t2. Фамилию\t3.Номер телефона\t4.Дату рождения");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение");

            bank.EditInfo(id, choose, Console.ReadLine());
        }
        private static void Search(Bank bank)
        {
            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите возраст:");

            string input = Console.ReadLine();
            int? age;
            if (input == "")
                age = null;
            else age = int.Parse(input);

            bank.Search(name, surname, age);
        }

        private static void GetList(Bank bank)
        {
            bank.GetList();
        }

        private static void ResumeThread(Thread thread)
        {
            thread.IsBackground = false;
        }
        private static void FreezeThread(Thread thread)
        {
            thread.IsBackground = true;
        }
        private static void ThreadWait(object Object)
        {
            while (alive)
            {
                Thread.Sleep(2000);
                if (Thread.CurrentThread.IsBackground)
                    continue;

                Bank bank = (Bank)Object;
                bank.SkipTime(1);
            }
        }
    }
}

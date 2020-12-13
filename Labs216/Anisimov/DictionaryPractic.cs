using System;
using System.Collections.Generic;

namespace Labs216.Anisimov
{
    class DictionartEditor
    {
        public static void Run()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            bool alive = true;

            while (alive)
            {
                try
                {
                    Console.WriteLine("1.Добавить имя\t2.Показать словарь\t3.Выйти из программы");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Имя:");
                            AddName(names, (Console.ReadLine()));
                            break;
                        case "2":
                            ShowDictionary(names);
                            break;
                        case "3":
                            alive = false;
                            break;
                    }
                }
                catch (Exception exception)
                {
                    var tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exception.Message);
                    Console.ForegroundColor = tmp;
                }
            }
        }

        private static void AddName<TValue>(Dictionary<int, TValue> dictionary, TValue NewValue)
        {
            if (string.IsNullOrEmpty(NewValue.ToString()))
                throw new Exception("Value is empty");
            dictionary.Add(dictionary.Count + 1, NewValue);
        }

        private static void ShowDictionary<TKey,TValue>(Dictionary<TKey,TValue> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"ID:{item.Key}\tName:{item.Value}");
            }
        }
    }
}

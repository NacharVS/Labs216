using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class DictionaryEditor
    {
        public static void AddValue<TValue>(Dictionary<int,TValue> dictionary, TValue NewValue)
        {
            if (string.IsNullOrEmpty(NewValue.ToString()))
                throw new Exception("Wrong value");
            dictionary.Add(GenKey(dictionary), NewValue); 
        }

        public static void RemoveValue<TValue>(Dictionary<int, TValue> dictionary, int Key)
        {
            if (dictionary.ContainsKey(Key))
                dictionary.Remove(Key);
            else
                throw new Exception("Wrong key");
                
        }

        private static int GenKey<TValue>(Dictionary<int, TValue> dictionary)
        {
            int LastKey = 0;
            foreach (var item in dictionary)
            {
                if (item.Key > LastKey)
                    LastKey = item.Key;
            }
            return LastKey + 1;
                
        }

        public static void ShowDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Id:{item.Key} \t Value:{item.Value}");
            }
        }
    }

    class DictionaryRun
    {
        public static void Run()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            bool alive = true;

            while(alive)
            {
                try
                {
                    Console.WriteLine("1.Add Name\t 2.Remove Name\t 3.Show dictionary\t 4.End");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("New value:");
                            DictionaryEditor.AddValue(names, Console.ReadLine());
                            break;
                        case "2":
                            Console.WriteLine("Key:");
                            DictionaryEditor.RemoveValue(names, int.Parse(Console.ReadLine()));
                            break;
                        case "3":
                            DictionaryEditor.ShowDictionary(names);
                            break;
                        case "4":
                            alive = false;
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    var tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exeption.Message);
                    Console.ForegroundColor = tmp;
                }
            }
        }
    }
}

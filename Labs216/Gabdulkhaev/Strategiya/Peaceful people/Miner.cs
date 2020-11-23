using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya.Peaceful_people
{
    class Miner : Character, IHoditable, IRabotable
    {
        public int kirka_sost = 100;
        public void Hodit()
        {
            Console.WriteLine("Шахтер пошел в шахту");
        }
        public void Rabota()
        {
            var date = DateTime.Now;
            if (DateTime.Now > date) // по истечении времени кирка должна терять прочность на 10, либо можно было это закинуть в первый if и при выполнении цикла снижать прочность
            {
                kirka_sost = kirka_sost - 10;
            }
                int resurse_in_the_chaxte = 1000; // Ресурсов в шахте 1к, но их надо пополнять
                Random rnd = new Random();
                int luck = rnd.Next(1, 10);
                Random rnd1 = new Random();
                int luck1 = rnd.Next(1, 10);
                if (luck!= luck1 && resurse_in_the_chaxte > 0 && kirka_sost > 0)
                {
                Console.WriteLine("Сколько шахтер должен накопать ресурсов?");
                int nakopal = Convert.ToInt32(Console.ReadLine());
                int resurse_int_chaxte = resurse_in_the_chaxte - nakopal;
                // kirka_sost=kirka_sost-10;
                Console.WriteLine("Шахтер идет в шахту и теряет 10 прочности кирки, при прочности меньше 0 он также откисает");
                }
                else if (luck==luck1)
                    Console.WriteLine("Вам повезло, luck=luck1, шахтер все, откис");
            }
        }
    }

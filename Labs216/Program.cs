using System;
using Labs216.Zamaliev;


namespace Labs216
{
    class program
    {
        static void Main(string[] args)
        {
            Bank account1 = new Bank("Petr", "Sidorov", 2000, 8.2, "1052560", 1000);

            account1.SetVozrast();

            account1.SetSchet();
            account1.SetStavka();
        }
    }
}

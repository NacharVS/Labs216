using Labs216.MirasovEG;
using Labs216.MirasovEG.Strategy;
using Labs216.Bank;
using System.Collections.Generic;
using Labs216.MirasovEG.BankAccountMongo;

namespace Labs216
{
    class Program
    {
        public static void Main(string[] args)
        {
            People people1 = new People("Egor", "Mirasov", 17, 853345533);
            People people2 = new People("Ivan", "Anisimov", 17, 856335636);

            MongoDB1.SaveDocs(people1).GetAwaiter().GetResult();

        }
    }
}

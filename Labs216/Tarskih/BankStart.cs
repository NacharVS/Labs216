using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class BankStart
    {
        public void StartProgram()
        {


            Bank person1 = new Bank("Ilnaz", "Dimmuhametov", 2288, 8, "89375567843");
            Bank person2 = new Bank("Maxim", "Kuzmin", 1448, 9, "89278812457");
            Bank person3 = new Bank("Vasya", "Pupkin", 2243, 4, "89049976798");
            Bank person4 = new Bank("Vanya", "Semechkin", 1995, 12, "92342342324");

            List<Bank> account = new List<Bank>();
            account.Add(person1);
            account.Add(person2);
            account.Add(person3);
            account.Add(person4);

            person1.ChangeSurname(account, 1, "fsej");
            person1.GetInform();
        }
    }
}

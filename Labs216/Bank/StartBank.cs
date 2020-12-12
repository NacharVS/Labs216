using System;
using System.Collections.Generic;
using System.Text;


namespace Labs216.Bank
{
    class StartBank
    {
        public void Start()
        {


            Bank person1 = new Bank("Rim", "Imin", 2000, 2, "89534578543");
            Bank person2 = new Bank("Nim", "IImin", 1999, 12, "89345827412");
            Bank person3 = new Bank("Mim", "IIImin", 2003, 4, "89453596854");
            Bank person4 = new Bank("Bim", "IVmin", 1995, 7, "89485769462");

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

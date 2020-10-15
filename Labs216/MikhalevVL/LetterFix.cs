using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MikhalevVL
{
    class LetterFix
    {
        static public void Letterfix()
        {
            Console.Write("Enter first name and surname "); // vasya pupkin
            string first = Console.ReadLine();
            Console.Write("Enter second name and surname ");
            string second = Console.ReadLine();
            Console.Write("Enter third name and surname ");
            string third = Console.ReadLine();
            Console.Write("Enter fourth name and surname ");
            string fourth = Console.ReadLine();
            Console.Write("Enter fifth name and surname ");
            string fifth = Console.ReadLine();

            string[] firstArray = first.Split(" "); // ["vasya", "pupkin"]
            string[] secondArray = second.Split(" ");
            string[] thirdArray = third.Split(" ");
            string[] fourthArray = fourth.Split(" ");
            string[] fifthArray = fifth.Split(" ");

            string nameFirst = firstArray[0].ToString();
            string nameSecond = secondArray[0].ToString();
            string nameThird = thirdArray[0].ToString();
            string nameFourth = fourthArray[0].ToString();
            string nameFifth = fifthArray[0].ToString();

            string surnameFirst = firstArray[1].ToString();
            string surnameSecond = secondArray[1].ToString();
            string surnameThird = thirdArray[1].ToString();
            string surnameFourth = fourthArray[1].ToString();
            string surnameFifth = fifthArray[1].ToString();

            Console.WriteLine(nameFirst[0].ToString().ToUpper() + surnameFirst[0].ToString().ToUpper());
            Console.WriteLine(nameSecond[0].ToString().ToUpper() + surnameSecond[0].ToString().ToUpper());
            Console.WriteLine(nameThird[0].ToString().ToUpper() + surnameThird[0].ToString().ToUpper());
            Console.WriteLine(nameFourth[0].ToString().ToUpper() + surnameFourth[0].ToString().ToUpper());
            Console.WriteLine(nameFifth[0].ToString().ToUpper() + surnameFifth[0].ToString().ToUpper());

        }
    }
}

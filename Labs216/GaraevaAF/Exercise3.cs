using System;


namespace Labs216.GaraevaAF
{
    class Exercise3
    {
        static public void Exercise31()
        {
            Console.WriteLine("Solve the Pythagorean theorem");
            Console.WriteLine("c*c = a*a + b*b");
            Console.ReadLine();
            Console.WriteLine("Enter the first leg length");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second leg length");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Now find the length of the hypotenuse");
            int c = 0;
            {
                if (a > 0)
                    c = (a * a) + (b * b);
                Console.WriteLine(c);
            }
        }
        
    }
}

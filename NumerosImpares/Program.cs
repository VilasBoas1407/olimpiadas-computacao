using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 1000)
            {
                for (int num = 1; num <= x;)
                {
                    if (num % 2 != 0)
                        Console.WriteLine(num);
                    num += 2;
                }
            }
        }
    }
}

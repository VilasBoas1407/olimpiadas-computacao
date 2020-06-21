using System;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2;

            NUM1 = Convert.ToInt32(Console.ReadLine());

            NUM2 = Convert.ToInt32(Console.ReadLine());

            int PROD = NUM1 * NUM2;

            Console.WriteLine("PROD = " + PROD + "\n");


        }
    }
}

using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric value ");
            ExtraLongFactorials(EnterIntValue());
            Console.ReadKey();
        }

        private static int EnterIntValue()
        {
            int c;
            while(!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Enter a numeric valid value");
            }

            return c;
        }

        static void ExtraLongFactorials(int n)
        {

            //long result = 1;
            BigInteger result = new BigInteger(1);

            for (int i = 0; i < n; i++)
            {
                result = result * (n - i);


            }

            Console.WriteLine("Factorial result: " + result);


        }
    }
}

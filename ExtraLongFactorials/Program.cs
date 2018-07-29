using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a numeric value ");
                ExtraLongFactorials(EnterIntValue());
            }
            //Console.ReadKey();
        }

        private static BigInteger EnterIntValue()
        {
            BigInteger c = new BigInteger(1);
            
            while(!BigInteger.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Enter a numeric valid value");
            }

            return c;
        }

        static void ExtraLongFactorials(BigInteger n)
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

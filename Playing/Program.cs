using System;

namespace Playing
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> CheckForPrimeNumber = p =>
            {
                bool isPrimeNumber = false;
                int i;
                for (i = 2; i <= p - 1; i++)
                {
                    if (p % i == 0) {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (i == p) {
                    isPrimeNumber = true;
                }
                return isPrimeNumber;
            };
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = CheckForPrimeNumber(number);
            Console.WriteLine($"{number} is {(isPrime ? "" : "not")} prime number");
            Console.Read();
        }
    }
}

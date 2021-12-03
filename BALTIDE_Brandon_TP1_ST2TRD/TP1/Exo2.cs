using System;

namespace TP1
{
    public class Exo2
    {
        public  bool isPrime(int number)
        {
            double sqrtNum = Math.Sqrt(number);
            for (int i = 2; i <= sqrtNum; i++)
            {
                if (number % 2 == 0) return false;
                
            }

            return true;
        }

        public void PrimeNumber()
        {
            for (var nb = 1; nb <= 1000; nb++)
            {
                var prime = isPrime(nb);
                if (prime)
                {
                    Console.WriteLine(nb);
                }
            }
        }

        public long fibo(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return fibo(number - 2) + fibo(number - 1);
            }
        }

        public int factorielle(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * factorielle(number - 1);
            }
        }
    }
}
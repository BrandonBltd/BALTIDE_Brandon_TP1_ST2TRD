using System;

namespace TP1
{
    public class Exo3
    {
        public void Calcul()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    var function = PowerFunction(i);
                    var result = 10 / function;
                    Console.WriteLine(result);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Warning ! " +ex.Message);
                }
            }
        }
        

        public int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }

    }
}
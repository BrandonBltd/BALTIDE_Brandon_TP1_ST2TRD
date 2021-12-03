using System;

namespace TP1
{
    public class Sapin
    {
        public int AskUser()
        {
            var size = 0;
            while (size == 0)
            {
                Console.WriteLine("Please enter the size of your beautiful fir : ");
                int.TryParse(Console.ReadLine(), out  size);
            }
            
            return size;
        }


        public void DrawFir()
        {
            var size = AskUser();
            for (int i = 0; i <= size; i++)
            {
                for(int j = 0; j<= size-i+1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= 2 * i + 1 - 1; j++)
                {
                    Console.Write("*");
                    
                }
                 
                Console.WriteLine("");

            }

            

            for (int i = 0; i <= size + 1; i++)
            {
                if (i == size + 1)
                {
                    for (int j = 0; j < ((size * 2-2 ) - 3); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (size * 2-1)/4 ; j++)
                    {
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
                
            }

            
        }
    }
}
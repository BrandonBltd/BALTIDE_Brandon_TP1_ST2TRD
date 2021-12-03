using System;

namespace TP1
{
    public class Multiplication
    {
        public int AskUser()
        {
            var nb = 0;
            while (true)
            {
                Console.WriteLine("Enter the number of which you want display the table : ");
                string number = Console.ReadLine();
                try
                {
                    if (number != null) nb = int.Parse(number);
                    break;
                }
                catch
                {
                    Console.WriteLine("Error ! Enter a valid number");
                }
            }

            return nb;
        }


        public bool oddNmber(int result)
        {
            bool test = result % 2 != 0;
            return test;
        }

        public void MultiplicationOp(bool odd = false)
        {
            var nb = AskUser();
            for (int i = 1; i <= 10; i++)
            {
                var result = nb * i;
                if ((odd == true) && (nb%2 !=0))
                {
                    var test = oddNmber(result);
                    if (test)
                    {
                        Console.WriteLine(nb+"*"+i+" = "+result);
                        
                    }

                    

                }
                else
                {
                    
                    Console.WriteLine(nb+"*"+i+" = "+result);
                }
               
            }
          
            
        }
    }
}
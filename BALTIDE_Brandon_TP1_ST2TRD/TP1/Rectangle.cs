using System;

namespace TP1
{
    public class Rectangle
    {
         public string[] AskNumber()
        {
            Console.WriteLine("Rentrer une hauteur et une largeur séparé par une virgule");
            var reponse =  Console.ReadLine();
            if (reponse == null) return AskNumber();
            var s = reponse.Split(',');
            return s;

        }

        public bool CheckValue(int hauteur, int largeur)
        {
            
            if ((hauteur < 0) || (largeur < 0) || (hauteur > 1000) || (largeur > 1000))
            {
                return false;
            }

            return true;
        }

        public string[] Draw()
        {
            var valueTab = AskNumber();
            int.TryParse(valueTab[0], out var hauteur); 
            int.TryParse(valueTab[1], out var largeur);
            
            if (CheckValue(hauteur, largeur) == false) return AskNumber();
            
            
                for (int ligne = 1; ligne <= hauteur; ligne++)
                {
                    
              
                    for (int col = 1; col <= largeur; col++)
                    {
                        
                        if (ligne == 1 && col == 1 || ligne == 1 && col == largeur || ligne == hauteur && col == 1 ||
                            ligne == hauteur && col == largeur)
                        {
                            Console.Write("0");
                        }
                        else if (ligne == 1 || ligne == hauteur)
                        {
                            Console.Write("-");
                        }
                        else if (col == 1 || col == largeur)
                        {
                            Console.Write("|");
                        }
                        else if ((col-ligne)%3==0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                   

                    
                    
                    Console.WriteLine();
                    
                }
            
          

            return null;

        }

        public void InterieurRect(int hauteur, int largeur)
        {
            for(int i= 1; i<= hauteur; i++)
            {
                for (int j = 1; j <= largeur; j++)
                {
                    if (j % 3 == 1)
                    {
                        Console.Write("*"); 
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                     
                    
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
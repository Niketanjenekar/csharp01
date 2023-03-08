using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Please enter the number of times you want to flip the coin");
            
            int Heads = 0;

            int Tails = 0;

            double headPercent = 0.0;

            double tailPercent = 0.0;

            int Flip=Convert.ToInt32(Console.ReadLine());

            if (Flip > 0)
            {
                for(int i = 0; i < Flip; i++)
                {
                 Random random = new Random();
                    int num = random.Next(2);
                    Console.WriteLine("Random numbers generates by system is : " +num );

                    switch(num)
                    {
                        case 0:
                            Console.WriteLine("It is Tails");
                            Tails = Tails + 1;
                            break; 
                        case 1:
                            Console.WriteLine("It is Heads");
                            Heads = Heads + 1;
                            break;
                    }
                }
                Console.WriteLine("The Head count is " + Heads );
                Console.WriteLine("The Head count is " + Tails);

               headPercent =Heads * 100 / Flip;
               tailPercent = Tails * 100 / Flip;
                Console.WriteLine("The Heads Percentage is " + headPercent);
                Console.WriteLine("The Tails percentage is " + tailPercent);
            }
        }
    }
}

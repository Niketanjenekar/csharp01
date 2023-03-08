using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Powerof2
    {
        public static void Powerofthe2()
        {
            Console.WriteLine("Please enter the number uptill that you want to print the power of 2 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if ( n < 31 )
            {
                Console.WriteLine("The table  :");

                for (int i = 0; i <= n; i++ )
                {
                    
                    Console.WriteLine("2^" + i + "=" + Math.Pow(2 , i ));
                } 
            }
        }
    }
}

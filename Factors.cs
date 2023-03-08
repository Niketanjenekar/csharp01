using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Factors
    {
        public static void Factorsof()
        {
            Console.WriteLine("Please enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Prime Factor of " + num + "is :");
            
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
            if (num > 1)
            {
                Console.Write(num);
            }

        }
    }
}


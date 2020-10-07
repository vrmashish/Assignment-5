using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7oct2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] repeatedArray = new int[10];
            int i, j, repeatCount = 0;
            int Index = 0;
            Console.WriteLine("Enter 10 numbers");
            for (i = 0; i < 10; i++)
            {
                repeatedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(repeatedArray);
            for (i = 0; i < 10; i = i + Index + 1)
            {
               
                for (j = 0; j < 10; j++)
                {
                    
                    if (repeatedArray[i] == repeatedArray[j])
                    {
                        repeatCount++;
                        Index = j;
                    }
                }
                Console.WriteLine("The duplicate item is {0} and it is repeated {1} times.", repeatedArray[Index],repeatCount);
                repeatCount = 0;
            }
            
        }
    }
}

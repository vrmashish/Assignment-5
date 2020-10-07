using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7oct2020
{
    class Operations
    {
        int ans;
        int input1, input2;
        int choice;
        void add(int x,int y)
        {
            ans = x + y;
        }
        void subtract(int x,int y)
        {
            ans = x - y;
        }
        void multiply(int x, int y)
        {
            ans = x * y;
        }
        void divide(int x,int y)
        {
            ans = x / y;
        }
        public void getdata()
        {
            Console.WriteLine("Enter the Two Numbers: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Choice: \n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n");
            choice = Convert.ToInt32(Console.ReadLine());
            calculation();
        }
        void calculation()
        {
            switch (choice)
            {
                case 1: add(input1, input2); break;
                case 2: subtract(input1, input2); break;
                case 3: multiply(input1, input2); break;
                case 4: divide(input1, input2); break;
                default: Console.WriteLine("Wrong Choice"); break;
            }
        }
        public void showdata()
        {
            Console.WriteLine("The answer is: {0}", ans);
        }
    }
}

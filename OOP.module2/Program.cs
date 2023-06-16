using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP.module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }
        public static class IntExtensions
        {
            public static int GetNegative(this int number)
            {
                if (number > 0)
                {
                    return -number;
                }
                else
                {
                    return number;
                }
            }
            public static int GetPositive(this int number)
            {
                if (number < 0)
                {
                    return -number;
                }
                else
                {
                    return number;
                }
            }
        }
    }

}

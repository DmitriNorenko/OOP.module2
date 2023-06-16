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
            int num1 = 34;
            int num2 = 56;
            Helper.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        class Helper
        {

            public static void Swap(ref int a, ref int b)
            {
                int d = a;
                a = b;
                b = d;
            }
        }
    }

}

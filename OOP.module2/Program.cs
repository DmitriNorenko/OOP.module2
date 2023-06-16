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

        }
        class Obj
        {
            public string Name;
            public string Description;
            public static string Parent;
            public static int DaysInWeek;
            public static int MaxValue;
            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                MaxValue = 2000;
            }
        }
    }

}

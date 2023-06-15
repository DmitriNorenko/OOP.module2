using System;
using System.Collections.Generic;
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
        class BaseClass
        {
            public virtual int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {
            public override int Counter
            {
                get { return Counter; }
                set 
                {
                    if (value >= 0)
                    {
                        Counter = value;
                    }
                }
            }
        }
    }
}

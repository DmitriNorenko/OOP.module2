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
        class Car<T>
        {
            public T Engine;

            public virtual void ChangePart<T>(T newPart)
            {

            }
        }
        class ElectricEngine { }

        class GasEngine { }

        class Battery { }

        class Differential { }

        class Wheel { }
    }

}




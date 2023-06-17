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
        class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;

            public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
            {

            }
        }
        class Engine { }

        class CarPart { }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }
    }

}




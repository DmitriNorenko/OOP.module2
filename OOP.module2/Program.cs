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
            ElectricCar car = new ElectricCar();
            Battery battery = new Battery();
            car.ChangePart<CarPart>(battery);
        }
        abstract class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;

            public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
            {

            }
        }
        abstract class Engine { }

        abstract class CarPart { }
        class ElectricCar : Car<ElectricEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }
        class GasCar : Car<GasEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }
    }

}




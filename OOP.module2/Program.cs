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
        public abstract class ComputerPart
        {
            public abstract void Work();
        }
        public class Processor : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Процессор работает.");
            }
        }
        public class MotherBoard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Материнская плата работает");
            }
        }
        public class GraphicCard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Видеокарта работает.");
            }
        }
    }

}

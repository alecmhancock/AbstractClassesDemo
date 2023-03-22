using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasSpoiler { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Car Drive.");
        }

        public override void VariableWrite()
        {
            Console.WriteLine($"The fact that this car has a spoiler is {HasSpoiler}.");
        }
    }
}

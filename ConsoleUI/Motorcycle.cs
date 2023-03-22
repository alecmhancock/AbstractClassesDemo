using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool IsChoppy { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Motorcycle Drive.");
        }

        public override void VariableWrite()
        {
            Console.WriteLine($"The fact that this motorcycle is choppy is {IsChoppy}.");
        }
    }
}

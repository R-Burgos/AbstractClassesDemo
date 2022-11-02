using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool hasTrunk = true;
        public override void DriveAbstract()
        {
            //Number of Wheels
            Console.WriteLine("Has four wheels.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCart = false;
        public override void DriveAbstract()
        {
            //Number of Wheels
            Console.WriteLine("Has two wheels.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Does not come equipped with a spare tire.");
        }
    }
}

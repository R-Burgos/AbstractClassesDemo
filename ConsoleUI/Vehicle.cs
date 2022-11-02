using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year = "1999";
        public string Make = "Honda";
        public string Model = "Civic";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            //Has spare tire.
            Console.WriteLine("Comes equipped with a spare tire.");
        }
    }
}

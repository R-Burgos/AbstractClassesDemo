using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE
            var vehicleList = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class - DONE
             * Set the properties with object initializer syntax - DONE
             */
            var car1 = new Car() { Year = "2022", Make = "Toyota", Model = "Camry" };
            var moto1 = new Motorcycle() { Year = "2022", Make = "Harley Davidson", Model = "Sportster S"};
            Vehicle car2 = new Car() { Year = "2023", Make = "Audi", Model = "R8"};
            Vehicle moto2 = new Motorcycle() { Year = "2020", Make = "Suzuki", Model = "Katana"};
            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */
            vehicleList.Add(car1);
            vehicleList.Add(moto1);
            vehicleList.Add(car2);
            vehicleList.Add(moto2);
            foreach (var vehic in vehicleList)
            {
                Console.WriteLine("----------");
                Console.WriteLine(vehic.Year);
                Console.WriteLine(vehic.Make);
                Console.WriteLine(vehic.Model);
                Console.WriteLine("----------");
            }
            // Call each of the drive methods for one car and one motorcycle - DONE
            Console.WriteLine(car1.Year + " " + car1.Make + " " + car1.Model);
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine("----------");
            Console.WriteLine(moto1.Year + " " + moto1.Make + " " + moto1.Model);
            moto1.DriveAbstract();
            moto1.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}

﻿using System;
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
             *Done Create an abstract class called Vehicle
             *Done The vehicle class shall have three string properties Year, Make, and Model
             *Done Set the defaults to something generic in the Vehicle class
             * Done Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *Dpone Provide the implementations for the abstract methods
             * Done Only in the Motorcycle class will you override the virtual drive method
            */

            //DONE Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = false, Make = "Kawasaki", Model = "Ninja", Year = 2014 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2020 };
            Vehicle hatchback = new Car() { HasTrunk = true, Make = "Toyota", Model = "Rav4", Year = 2019 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(hatchback);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year} ");
                veh.DriveAbstract();
                Console.WriteLine("--------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{

    /*
 * DONE Create an abstract class called Vehicle
 * DONE The vehicle class shall have three string properties Year, Make, and Model
 * DONE Set the defaults to something generic in the Vehicle class
 * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
 * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
 */
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Default Make";

        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

    }
}

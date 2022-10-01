using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int year { get; set; } = 2000;
        public string make { get; set; } = "Default Make";
        public string model { get; set; } = "Defualt Model";

        public abstract void DriveAbstract(); //stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");
        }
    }
}

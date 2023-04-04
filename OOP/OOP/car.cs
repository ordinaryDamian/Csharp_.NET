using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
            
        public int horsePower;
        public string color;
        public bool fourWheels;
        public void senzorOff()
        {
            Console.WriteLine("Dvere sú zavreté"); 
        }
        public Car()
        {
            horsePower = 1111;
            Console.WriteLine(horsePower);
        }
    }
}

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
        public int year;
        //public void senzorOff()
        //{
        //    Console.WriteLine("Dvere sú zavreté"); 
        //}
        //public Car() //konstruktor
        //{
        //    horsePower = 1111;
        //    Console.WriteLine(horsePower);
        //}
        public Car(int modelHorsePower, string modelColor, int modelYear)
        {
            horsePower = modelHorsePower;
            color = modelColor; 
            year = modelYear;
        }
    }
}

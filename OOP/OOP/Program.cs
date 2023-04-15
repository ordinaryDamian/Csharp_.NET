using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP //nazov projektu
{
    internal class Program //class dost casto meno suboru
    {
        public int horsePower; //vytvorenie konstruktora
        public string color;
        public int year;

        public Car(int modelHorsePower, string modelColor, int modelYear)
        {
            horsePower = modelHorsePower;
            color = modelColor;
            year = modelYear;
        }//az sem sa tvory konstruktor

        static void Main(string[] args)
        {
            //Car myObj = new Car(); //s týmto volam aĵkonstruktor v druhom súbore
            //Car myObj1 = new Car(); //once again zase ho vola   
            //    //myObj1.color = "orange";
            //Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj1.color);
            //Console.WriteLine(myObj.horsePower);
            //Console.WriteLine(myObj1.horsePower);
            //Console.WriteLine(myObj.fourWheels);
            //myObj1.fourWheels = false;
            //Console.WriteLine(myObj1.fourWheels == true ? "Auto ma 4 kolesá" : "Auto nemá 4 kolesá"); //uz pokracuje proceduralne hovori či je to true tak vypise prvu vec ak nie je true tak vypise druhu vec
            //myObj1.horsePower = 1000;
            //myObj.horsePower = 1500;
            //myObj1.color = "red";
            //myObj.color = "blue";
            //myObj1.fourWheels = true;
            //myObj.fourWheels = false;       
            //myObj1.senzorOff(); // zavolal som funkciu z druheho súboru

            Program Ford = new Program("Mustang", "Blue", 1968); // s konstruktorom vytvorenie objektu
            Console.WriteLine(Ford.color);

            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP //nazov projektu
{
    internal class Program //class dost casto meno suboru
    {
        static void Main(string[] args)
    {   
        Car myObj = new Car();
        Car myObj1 = new Car();
        myObj1.color = "orange";
        // int HPplus = int.Parse(Console.ReadLine());
        // myObj.horsePower = myObj.horsePower + HPplus;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj.horsePower);
        Console.WriteLine(myObj1.horsePower);
        Console.WriteLine(myObj.fourWheels);
        myObj1.fourWheels = false;
        Console.WriteLine(myObj1.fourWheels == true ? "Auto ma 4 kolesá" : "Auto nemá 4 kolesá"); //uz pokracuje proceduralne hovori či je to true tak vypise prvu vec ak nie je true tak vypise druhu vec
        Console.ReadKey();

    }
    }
}
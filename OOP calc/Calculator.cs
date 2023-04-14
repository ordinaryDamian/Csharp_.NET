using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_calc
{

    public class Calculator
    {
        public int cislo1;
        public int cislo2;
        public Calculator(int Cislo1, int Cislo2)
        {
            cislo1 = Cislo1;
            cislo2 = Cislo2;

        }
        int add = cislo1 + cislo2;
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator(1, 2);
            Console.WriteLine(calc.add);
            // Console.WriteLine(calc.cislo2);
        }
    }
}
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_calc
{
    // FIXME: tu to zacina
    internal class Calculator
    {
        int cisloA;
        int cisloB;
        public int Add(int cisloA, int cisloB)
        {
            return cisloA + cisloB;
        }
        public int Subtract(int cisloA, int cisloB)
        {
            return cisloA - cisloB;
        }
        public int Multiply(int cisloA, int cisloB)
        {
            return cisloA * cisloB;
        }
        public double Divide(double cisloA, double cisloB)
        {
            return cisloA / cisloB;
        }

        public static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            Console.WriteLine("Sčítanie: " + myCalculator.Add(2, 3));
            Console.WriteLine("Odčítanie: " + myCalculator.Subtract(5, 2));
            Console.WriteLine("Násobenie: " + myCalculator.Multiply(4, 6));
            Console.WriteLine("Delenie: " + myCalculator.Divide(10, 2));
        }
    }



    // internal class Calculator
    // {
    //     public double Add(double num1, double num2)
    //     {
    //         return num1 + num2;
    //     }

    //     public double Subtract(double num1, double num2)
    //     {
    //         return num1 - num2;
    //     }

    //     public double Multiply(double num1, double num2)
    //     {
    //         return num1 * num2;
    //     }

    //     public double Divide(double num1, double num2)
    //     {
    //         if (num2 == 0)
    //         {
    //             throw new DivideByZeroException("Cannot divide by zero");
    //         }
    //         return num1 / num2;
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Welcome to the calculator!");

    //         Calculator calculator = new Calculator();

    //         while (true)
    //         {
    //             Console.WriteLine("\nPlease choose an operation:");
    //             Console.WriteLine("1. Add");
    //             Console.WriteLine("2. Subtract");
    //             Console.WriteLine("3. Multiply");
    //             Console.WriteLine("4. Divide");

    //             int choice = Convert.ToInt32(Console.ReadLine());

    //             Console.WriteLine("\nEnter the first number:");
    //             double num1 = Convert.ToDouble(Console.ReadLine());

    //             Console.WriteLine("Enter the second number:");
    //             double num2 = Convert.ToDouble(Console.ReadLine());

    //             double result = 0;

    //             switch (choice)
    //             {
    //                 case 1:
    //                     result = calculator.Add(num1, num2);
    //                     break;
    //                 case 2:
    //                     result = calculator.Subtract(num1, num2);
    //                     break;
    //                 case 3:
    //                     result = calculator.Multiply(num1, num2);
    //                     break;
    //                 case 4:
    //                     try
    //                     {
    //                         result = calculator.Divide(num1, num2);
    //                     }
    //                     catch (DivideByZeroException e)
    //                     {
    //                         Console.WriteLine(e.Message);
    //                         continue;
    //                     }
    //                     break;
    //                 default:
    //                     Console.WriteLine("Error: invalid choice");
    //                     continue;
    //             }

    //             Console.WriteLine("\nThe result is: " + result);
    //             Console.WriteLine("\nPress any key to continue or 'q' to quit.");
    //             string input = Console.ReadLine();

    //             if (input.ToLower() == "q")
    //             {
    //                 break;
    //             }
    //         }

    //         Console.WriteLine("Thank you for using the calculator!");
    //     }
    // }
}
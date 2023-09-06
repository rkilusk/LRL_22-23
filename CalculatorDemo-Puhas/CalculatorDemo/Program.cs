using System;
using CalculatorLib;

namespace CalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate("15+5");
            Calculate("15-5/2");
            Calculate("2*3-1/5+8");
            Calculate("4+2C2+3");
        }

        static void Calculate(string expression)
        {
            Console.Write(expression);
            Console.Write("=");

            var calculator = new Calculator();

            foreach(var c in expression)
            {
                calculator.KeyPress(c);
            }

            calculator.KeyPress('=');

            Console.WriteLine(calculator.Result);
        }
    }
}

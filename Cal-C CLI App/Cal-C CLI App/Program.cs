using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_C_CLI_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            float num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter Second Number: ");
            float num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select the Operator: ");
            String ops = Console.ReadLine();

            if (ops == "+")
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            }
            else if (ops == "-")
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            }
            else if (ops == "*")
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            }
            else if (ops == "/")
            {
                Console.WriteLine(num1 + " / " + num2 + " = " + (float)(num1 / num2));
            }
            else if (ops == "^")
            {
                Console.WriteLine(num1 + " ^ " + num2 + " = " + (float)(Math.Pow(num1, num2)));
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----------------------------"); 
            Console.Write("\n");                               
            Console.WriteLine("Enter the First Number");
            Console.Write("----------------------------");
            Console.Write("\n");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("-------------------------------------------------------");
            Console.Write("\n");
            Console.WriteLine("Enter Second Number");
            Console.Write("-------------------------------------------------------");
            Console.Write("\n");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("-------------------------------------------------------");
            Console.Write("\n");
            Console.WriteLine("Enter the operator sign (e.g +, -, *, /, %)");
            Console.Write("-------------------------------------------------------");
            Console.Write("\n");
            string Operator = Console.ReadLine();
            Console.Write("\n");

            if (Operator.Equals("*"))
            {
                Console.WriteLine(firstNumber * secondNumber);
                Console.Write("\n");
            }

            else if (Operator.Equals("-"))
            {
                Console.WriteLine(firstNumber - secondNumber);
                Console.Write("\n");
            }

            else if (Operator.Equals("+"))
            {
                Console.WriteLine(firstNumber + secondNumber);
                Console.Write("\n");
            }

            else if (Operator.Equals("/"))
            {
                Console.WriteLine(firstNumber / secondNumber);
                Console.Write("\n");
            }

            else if (Operator.Equals("%"))
            {

                Console.Write("-------------------------------------------------------");
                Console.Write("\n");
                Console.Write("\n");
                Console.WriteLine(firstNumber % secondNumber);
                Console.Write("-------------------------------------------------------");

            }



            Console.ReadLine();
        
        }
    }
}

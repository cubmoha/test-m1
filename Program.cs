using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var calculator = new Calculator();
            
            var input = Console.ReadLine();

            Console.WriteLine("Enter 2 integers:");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();


            if (int.TryParse(number1, out int numberOne) && int.TryParse(number2, out int numberTwo))
            {

                if (input == "1")
                {
                    Console.Write($"{number1} + {number2} = ");
                    Console.Write(calculator.Add(numberOne, numberTwo));
                }
                else if (input == "2")
                {
                    Console.Write($"{number1} - {number2} = ");
                    Console.Write(calculator.Subtract(numberOne, numberTwo));
                }
                else if (input == "3")
                {
                    Console.Write($"{number1} * {number2} = ");
                    Console.Write(calculator.Multiply(numberOne, numberTwo));
                }
                else if (input == "4")
                {
                    Console.Write($"{number1} / {number2} = ");
                    Console.Write(calculator.Divide(numberOne, numberTwo));
                }
                else
                {
                    Console.WriteLine("The press number must be between 1 to 4!");
                }
                Console.Read();
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
            











        }
    }
}
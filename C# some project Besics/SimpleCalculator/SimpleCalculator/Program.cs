using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal num1, num2, result = 0;
            Char operate;
            int time;
            Console.Write("Enter the times you want to calculate: ");
            time = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < time; i++)
            {
                Console.Write("Enter the First Number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter the Secound Number: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter the Operation:(+,-,*,/,%) ");
                operate = Convert.ToChar(Console.ReadLine());
                switch (operate)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("The add value is : " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("The Sub value is : " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("The Mul value is : " + result);
                        break;
                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("The Div value is : " + result);
                        break;
                    case '%':
                        result = num1 % num2;
                        Console.WriteLine("The ModDiv value is : " + result);
                        break;
                    default:
                        Console.WriteLine(operate + " this is an error.....");
                        break;
                }
                Console.WriteLine("Press Enter for next Chance....");
                Console.ReadKey();
            }
        }
    }
}

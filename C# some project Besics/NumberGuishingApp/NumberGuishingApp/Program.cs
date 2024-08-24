using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 me,com;
            Random random = new Random();
            int time;
            Console .WriteLine("Enter how much time you want to continue...");
            time =Convert .ToInt32 (Console.ReadLine());
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine("Enter a value Between 1 to 10 (Use only The Integer Number...)");
                me = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value from computer..");
                com = random.Next(1, 10); // use the random function between 1 to 10 
                Console.WriteLine(com);
                if (me == com)
                {
                    Console.WriteLine("Value match ...Game over");
                }
                else if (me != com)
                {
                    Console.WriteLine("Value not match ...");
                }
                else
                {
                    Console.WriteLine("Error .....");
                }
                Console.WriteLine("Press the enter key to continue..");
                Console.ReadKey();

            }
        }
    }
}

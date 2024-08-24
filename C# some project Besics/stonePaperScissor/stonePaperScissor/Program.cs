using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stonePaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 me, com,times;
            Console.WriteLine("How much time you want to play...");
            times=Convert.ToInt32(Console.ReadLine());

            for(Int32 i =0; i<times;i++){
            Console.WriteLine("Enter 1 for 'stone', Enter 2 for 'paper', Enter 3 for 'Scissor' : ");
            me=Convert.ToInt32(Console.ReadLine());
            if (me == 1)
            {
                Console.WriteLine("You chose 'Stone'...");
            }
            else if (me == 2)
            {
                Console.WriteLine("You chose 'Paper'...");
            }
            else if (me == 3)
            {
                Console.WriteLine("You chose 'Paper'...");
            }
            else
            {
                Console.WriteLine("Showing Error...");
            }
            Random random = new Random();
            com = random.Next(1,3);
            switch(com)
            {
                case 1:
                    Console.WriteLine("Computer chose : Stone");
                    break;
                case 2:
                    Console.WriteLine("Computer chose : Paper");
                    break;
                case 3:
                    Console.WriteLine("Computer chose : Scissor");
                    break;
                default:
                    Console.WriteLine("Computer chose :" + com + ", Error...");
                    break;
            }

            if (com == me)
            {
                Console.WriteLine("Both chose same , Game Over...");
            }
            else if(me!= com)
            {
                Console.WriteLine("You chose: "+me+" and computer chose: "+com);
            }
            else
            {
                Console.WriteLine("Showing Some Error...");
            }
           }
           Console.ReadKey();
        }
    }
}

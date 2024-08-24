using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Billing System");
            Console.Write("Enter the customer's name: ");
            String Name = Console.ReadLine();
            Console.Write("Enter customer's Ph Number :");
            string PhNo = Console.ReadLine();
            int product;
            double quentity;
            double total=0;
            double totalvalue = 0;
            int i = 1;
            while (i < 7)
            {
                string[] items = { "1.chiken", "2.motton", "3.egg", "4.rice", "5.dal", "6.moshla" };
                Console.WriteLine("Chose the item from the bellow list by using item number:");
                Console.WriteLine("_____________________________________________________________");
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_____________________________________________________________");

                product = Convert.ToInt32(Console.ReadLine());
                switch (product)
                {
                    case 1:
                        Console.WriteLine("you chose chiken..\nPrice 100/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 100;
                        break;
                    case 2:
                        Console.WriteLine("you chose motton..\nPrice 700/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 700;
                        break;
                    case 3:
                        Console.WriteLine("you chose egg..\nPrice 200/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 200;
                        break;
                    case 4:
                        Console.WriteLine("you chose rice..\nPrice 20/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 20;
                        break;
                    case 5:
                        Console.WriteLine("you chose dal..\nPrice 210/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 210;
                        break;
                    case 6:
                        Console.WriteLine("you chose moshla..\nPrice 70/kg");
                        Console.WriteLine("Enter the quentity you want in kg:");
                        quentity = Convert.ToDouble(Console.ReadLine());
                        total = quentity * 70;
                        break;
                    default:
                        Console.WriteLine("you chose a wrong key...");
                        break;
                }
                totalvalue = totalvalue + total;

            here:
                Console.WriteLine("Do you want to add more item write: yes, or  if you want to exit write:exit ");
                string chose;
                chose = Console.ReadLine();
                if (chose == "exit" || chose == "EXIT"|| chose=="Exit")
                {
                    break;
                }
                else if (chose == "Yes" || chose == "yes" || chose == "YES")
                {
                    i += 1;
                }
                else
                {
                    Console.WriteLine("invalide input..");
                    goto here;
                }

            }
            
            
            Console.WriteLine("You have to pay: {0}",totalvalue);

            Console.ReadKey();
        }
    }
}

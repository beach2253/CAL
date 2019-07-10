using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.Write("Input Num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Operation (+),(-),(*),(/)  : ");
            string oper = Console.ReadLine();


            Console.Write("Input Num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());


                    switch (oper) 
                {
                      case "+" :
                           
                          Console.WriteLine(num1+num2);
                    Console.Read();
                          break;
                      case "-":
                    Console.WriteLine(num1 - num2);
                    Console.Read();
                    break;
                      case "*":
                    Console.WriteLine(num1 * num2);
                    Console.Read();
                    break;
                      case "/":
                    Console.WriteLine(num1 / num2);
                    Console.Read();
                    break;
                      default:
                        Console.WriteLine("Input Again");
                        break;
                }




        }
    }
}

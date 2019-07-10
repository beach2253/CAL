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

            string c;
            string check = "Y";

            do
            {



                process();
                Console.Write("Do you want to use a calculator? (Y/N) ");
                c = Console.ReadLine();
                string c1 = c.ToUpper();




           
            }
         

            while (c == check);



            Console.Write("Good Bye");
            Console.Read();
            Environment.Exit(0);
        }
    
        
        public static void process()
        {

            Console.Write("Input Num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Operation (+),(-),(*),(/)  : ");
            string oper = Console.ReadLine();


            Console.Write("Input Num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            switch (oper)
            {
                case "+":

                    Console.WriteLine(num1 + num2);
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    Console.ReadLine();
                    break;
                default:
                    
                    break;
            }



        }

    }
 }


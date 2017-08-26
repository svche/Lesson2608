using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2608
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter number from 1 to 7: ");
            int num = int.Parse(Console.ReadLine());

            
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("1 is Sunday");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("2 is Monday");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3 is Tuesday");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4 is Wednesday");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5 is Thursday");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("6 is Friday");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7 is Saturday");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("incorrect value, repeat please");
                            break;
                        }
                }
                */
            /*
                        string password = "asd";

                        Console.Write("Enter the pasword: ");
                        string youPassword = Console.ReadLine();

                        if (password.Equals(youPassword))
                        {
                            Console.WriteLine("It's ok");
                        } else
                        {
                            Console.WriteLine("Incorrect password");

                        }
            */
            /* 
            string password = "asd";
            bool b = true;
            int counter = 0;

            do
            {
                Console.Write("Enter the pasword: ");
                string youPassword = Console.ReadLine();

                if (password.Equals(youPassword))
                {
                    Console.WriteLine("It's ok");
                    b = false;
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("stop it, hacker");
                        break;
                    }
                }
            }
            while (b);
            */

            /*
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                    
                }
                Console.WriteLine();
            }

            for (int i = n; i > 0; i--)
            {
                for (int j = i-1; j > 0; j--)
                {
                    Console.Write('*');

                }
                Console.WriteLine();
            }
            */
            /* 

            for (int i = 0; i <= 255; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(" " + i);
            }
            */

            Console.Write("enter size of squre: ");
            int num = int.Parse(Console.ReadLine())
            




                Console.ReadLine();

            }
        }
    }


using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("------Calculator-----");
                Console.WriteLine("Enter 1 to do Addition operation");
                Console.WriteLine("Enter 2 to do Subtraction operation");
                Console.WriteLine("Enter 3 to do Multiplication operation");
                Console.WriteLine("Enter 4 to do Division operation");
                Console.WriteLine("Enter 5 to Quit program");
                op = GetNumberFromUser();

                switch (op)
                {
                    case 1:
                     int addOutput = AddMethod();
                        Console.WriteLine("The addition of two number is:  " + addOutput);
                        break;
                    case 2:
                        int subOutput = SubtractionMethod();
                        Console.WriteLine("The Subtraction of two number is:  " + subOutput);
                        break;
                    case 3:
                      int mulOutput = MultiplicatinMethod();
                        Console.WriteLine("The Multiplication of two number is:  " + mulOutput);
                        break;
                    case 4:
                   double divOutput =  DivisionMethod();
                        Console.WriteLine("The Division of two number is:  " + divOutput);
                        break;
                    default:
                        Console.WriteLine("Press 5 to terminate the Program");
                        break;


                }

            } while (op != 5);

          
        } //End of Main Method
        static int AddMethod()
        {
            Console.WriteLine("Enter two number");
            int result = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int x,y = 0;
            int.TryParse(b, out y);
            int.TryParse(a ,out x);
            result = x + y;
            return result;
        }
        static int SubtractionMethod()
        {
            Console.WriteLine("Enter two number");
            int result = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int x, y = 0;
            int.TryParse(b, out y);
            int.TryParse(a, out x);
            result = x - y;
            return result;
        }
        static int MultiplicatinMethod()
        {
            Console.WriteLine("Enter two number");
            int result = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int x, y = 0;
            int.TryParse(b, out y);
            int.TryParse(a, out x);
            result = x * y;
            return result;
        }
        static double DivisionMethod()
        {
            Console.WriteLine("Enter two number");
            int result = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int x, y = 0;
            int.TryParse(b, out y);
            int.TryParse(a, out x);
            if (x == 0 || y == 0)
            {
                Console.WriteLine("You can not divide number by Zero please enter valid positive number");
            }
            else
            {
                result = x / y;
            }
            return result;
        }
        static int GetNumberFromUser()
        {
            string userInput = Console.ReadLine();
            int num = 0;
            int.TryParse(userInput, out num);
            return num;
        }

        }
        
     
        
    }


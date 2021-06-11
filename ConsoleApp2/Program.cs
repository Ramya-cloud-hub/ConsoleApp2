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
                         AddMethod();
                        break;
                    case 2: SubtractionMethod();
                        break;
                    case 3:MultiplicatinMethod();
                         break;
                    case 4:DivisionMethod();
                         break;
                    default:
                        Console.WriteLine("Press 5 to terminate the Program");
                        break;
                }

            } while (op != 5);
        } //End of Main Method

        //Implimentation of Add method
        static void AddMethod()
        {
            Console.WriteLine("Enter two input number to add");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            double x,y = 0;
            if(double.TryParse(num1,out x ) && double.TryParse(num2 , out y)){
                Console.WriteLine("The addition of two given number is :\n" + (x+y));
            }
            else
            {
                Console.WriteLine("Enter a valid input numer");
            }
        }
        //Subtraction Function
        static void SubtractionMethod()
        {
            Console.WriteLine("Enter two input number to subtract");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            double x, y = 0;
            if (double.TryParse(num1, out x) && double.TryParse(num2, out y))
            {
                Console.WriteLine("The Subtraction of two given number is:\n" +(x-y));
            }
            else
            {
                Console.WriteLine("Enter a valid input numer");
            }
        }
        //Implimentation of Multiplication Method
        static void MultiplicatinMethod()
        {
            Console.WriteLine("Enter two input number to multiplicate");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            double x, y = 0;
            if (double.TryParse(num1, out x) && double.TryParse(num2, out y))
            {
                Console.WriteLine("The Multiplication of of two given number is:\n" + (x * y));
            }
            else
            {
                Console.WriteLine("Enter a valid input numer");
            }
        }
        //Implimentation of division method
        static void DivisionMethod()
        {
                Console.WriteLine("Enter two numbers for division");
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                double x, y = 0;
            if (double.TryParse(num1, out x) && double.TryParse(num2, out y))
            {
                if (x == 0 || y == 0)
                {
                    Console.WriteLine("You can not divide number by Zero please enter valid positive number");
                }
                else
                {
                    Console.WriteLine("The Division of two given number is:\n" + (x / y));
                }  
            }
            else
            {
                Console.WriteLine("Enter a valid input numer");
            }

        }
        //Implimentation of UserInput function
        static int GetNumberFromUser()
        {
            int number = 0;
            string input = Console.ReadLine();
            if(!int.TryParse(input,out number))
            {
                Console.WriteLine("Given input is not Valid Enter valid number");
            }
            return number;
        }
    }          
}


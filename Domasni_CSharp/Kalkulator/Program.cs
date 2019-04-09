using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {

                Console.Write("Please enter the first integer: ");
                if()
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Break (Y/y to exit or Anybutton to continue !!!)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n________________________________\n");
                    continue;

                }
                
                else if (status.Key == ConsoleKey.N)
                {
                    
                    
                    Console.WriteLine(" \n ________________________________");
                    Console.WriteLine("|GOOOOOODBYEEEEEEEEEEEEEEEEEE !!!|");
                    Console.WriteLine("|________________________________|");
                }
                Console.WriteLine("Press Enter to quit !");
                Console.ReadLine();break;
            }
        }
    }
}

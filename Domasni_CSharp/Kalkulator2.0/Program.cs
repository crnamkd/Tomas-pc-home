using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[0];
            int i = 0;
            string answer;
            do
            {
                Array.Resize(ref array, array.Length + 1);
                double result = 0;

                Console.Write("Please Enter the type of the arithmetic operation from the following (+, - , * , / )");
                string operation = Console.ReadLine();

                while (operation != "-" && operation != "+" && operation != "/" && operation != "*")
                {
                    if (operation.Length < 1)
                    {
                        Console.Write("You didn't enter the operator please enter one from the following (+, - , * , / ) ");
                        operation = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("You Entered invalid mathematical operator, please enter one from the following (+, - , * , / )");
                        operation = Console.ReadLine();
                    }
                }
                Console.Write("Please enter the first number, First Number= ");
                double firstNumber;
                bool convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);

                while (!convertFirst)
                {
                    Console.Write("You entered an invalid input for the First Number ! First Number= ");
                    convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);

                }

                Console.Write("Please enter the second number, Second number= ");
                double secondNumber;
                bool convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);

                while (!convertSecond)
                {
                    Console.Write("You entered an invalid input for the Second Number ! Second Number = ");
                    convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);


                }

                switch (operation)
                {
                    case "+":

                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "*":

                        while (firstNumber == 0)
                        {
                            if (convertFirst && firstNumber == 0)
                            {
                                Console.Write("You can't multiply with zero add number bigger then 0, First number= ");
                                convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);
                            }
                            else if (!convertFirst)
                            {
                                Console.Write("Now you entered invalid input try again, First number= ");
                                convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);
                            }
                        }

                        while (secondNumber == 0)
                        {
                            if (convertSecond && secondNumber == 0)
                            {
                                Console.Write("You can't multiply with zero add number bigger then 0, Second number= ");
                                convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);
                            }
                            else if (!convertSecond)
                            {
                                Console.Write("Now you entered invalid input try again, Second number= ");
                                convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);
                            }
                        }

                        result = firstNumber * secondNumber;

                        break;

                    case "/":

                        while (firstNumber == 0)
                        {
                            if (convertFirst && firstNumber == 0)
                            {
                                Console.Write("You can't divide with zero add number bigger then 0, First number= ");
                                convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);
                            }
                            else if (!convertFirst)
                            {
                                Console.Write("Now you entered invalid input try again, First number= ");
                                convertFirst = Double.TryParse(Console.ReadLine(), out firstNumber);
                            }
                        }

                        while (secondNumber == 0)
                        {
                            if (convertSecond && secondNumber == 0)
                            {
                                Console.Write("You can't divide with zero add number bigger then 0, Second number= ");
                                convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);
                            }
                            else if (!convertSecond)
                            {
                                Console.Write("Now you entered invalid input try again, Second number= ");
                                convertSecond = Double.TryParse(Console.ReadLine(), out secondNumber);
                            }
                        }

                        result = firstNumber / secondNumber;

                        break;


                }

                array[i] = $"{firstNumber}  {operation} {secondNumber} = {result} ";

                i++;

                Console.WriteLine("Result : " + firstNumber + " " + operation + " " + secondNumber + " = " + result);

                Console.Write("Do you want to make another calculation? (Y/N)");
                
}
                answer = Console.ReadLine();

                while (answer.ToUpper() != "Y" && answer.ToUpper() != "N")
                {
                    Console.Write("You need to answer with Y or N ");
                    answer = Console.ReadLine();
                }

                if (answer.ToUpper() == "Y")
                {
                    continue;
                }
                else if (answer.ToUpper() == "N")
                {
                    Console.WriteLine("Previosly calculations : ");
                    foreach (string item in array)
                    {
                        Console.WriteLine(item);
                    }
                }
                }


                Console.ReadLine();



            } while (answer.ToUpper() != "N");

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            var input = Console.ReadLine();
            Student[] students = new Student[1];
            char mesto = ' ';

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Student tomas = new Student
                {
                    Name = "tomas",
                    Academy = "seavus",
                    Group = 5
                };

                Student voislav = new Student
                {
                    Name = "voislav",
                    Academy = "none",
                    Group = 1
                };

                if(input == tomas.Name)
                {
                    Console.WriteLine(tomas.Name + mesto + tomas.Academy + mesto + tomas.Group);
                }
                else if(input == voislav.Name)
                {
                    Console.WriteLine(voislav.Name + mesto + voislav.Academy+ mesto  + voislav.Group);
                }
                else
                {
                    Console.WriteLine("You have entered invalid name");
                    Console.ReadLine();
                }

            }
            Console.ReadLine();

        }
    }
}

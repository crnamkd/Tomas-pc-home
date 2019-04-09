using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Classes;

namespace ConsoleApp2.Classes
{/*-------------------------------------------------------------------------------------------- 
        Class Person with properties for first name, last name, date of birth (DOB), social security
        number (SSN) and the possibility to have supermarket loyal buyer card;
        ➢ Class Product with properties for name, serial number, description, declaration;
        ➢ Class Cart with properties for serial number and list of products.
        Scenario:
        - User enters their personal info as buyer and cashier as well;
        - User can select products from list of previously defined products (loop until the selection
        is finished). [Reference loops and arrays code, materials and presentation]
        - When the selection is completed user is going to the cashier and introduce themselves
        with kind message; [Reference to methods code and presentation]
        - The cashier is accepting the products just in format of product names separated with
        comma (‘,’). You can user another special character separator as well;
        - The cashier is validating if the user is at least 18 years old if some of the products are
        declared for adults (dates operations);
        - After registering all products, the user is able to pay the check (if the cost is bigger than
        50$, additional discount of 10% is calculated) [Reference to string formatting materials];
        - If user has special loyal card, then additional 15% discount should be calculated;
        - Document each process with appropriate message on the display (strings operations).
        ---------------------------------------------------------------------------------------------*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Please add to cart \n1=leb(25.00)\n2=Mleko(45.7)\n3=Kafe(37.5)\n4=Jajca(60)");
            string operation = Console.ReadLine();
            */

            if (Console.ReadLine() = ConsoleKey.D1)
            { 
            Product[] catalog =
            {
                new Product("Leb", 25.00),
                new Product("Mleko", 45.7),
                new Product("Kafe", 37.5),
                new Product("Jajca", 60)
            };
            }
            Console.WriteLine("Total number of products in catalog is: " + Product.Count());

            var shoppingCart = new Cart();

            shoppingCart.AddItem(catalog[0]);
            shoppingCart.AddItem(catalog[3]);
            shoppingCart.AddItem(catalog[1]);

            shoppingCart.PrintTotalPrice();

            shoppingCart.CheckOut();

            Console.ReadLine();
        }
    }
}

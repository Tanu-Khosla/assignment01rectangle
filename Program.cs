using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
           // Console.ReadKey();
        }
        public void Go()
        {
            int output = ValidateMenuSelection();
       
            Rectangle r = new Rectangle();
          
            while (output != 7)
            {
                switch (output)
                {

                    case 2:
                        int l= ValidateUserInput("length");
                        r.SetLength(l);
                        break;
                    case 3:
                        Console.WriteLine($"Width is:{r.GetWidth()}\n");
                        break;
                    case 4:
                       int w = ValidateUserInput("width"); 
                        r.SetWidth(w);
                        break;
                    case 5:
                        Console.WriteLine($"Perimeter of Rectangle is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Area of rectangle:{r.GetArea()}\n");
                        break;
                    default:
                        break;

                }
                output = ValidateMenuSelection();

            }
        }
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;
            while (validMenuSelect == false)
            {
                Console.WriteLine("1=Get rectangle Length");
                Console.WriteLine("2=Change rectangle Length");
                Console.WriteLine("3=Get rectangle width");
                Console.WriteLine("4=Change rectangle width");
                Console.WriteLine("5=Get rectangle Perimeter");
                Console.WriteLine("6=Get rectangle Area");
                Console.WriteLine("7=Get Exit\n");
                Console.WriteLine("Please select an option by entering a number:\n");
                userInput = Console.ReadLine();
                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6" && userInput != "7")
                {
                    Console.WriteLine("There is not a valid menu option,Please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("That's not a valid input,Please try again.\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0,Please try again\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is now {number} \n");
                }
            }
            return (number);
        }

    }
}

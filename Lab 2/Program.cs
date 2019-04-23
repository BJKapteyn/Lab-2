using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDouble(string dub)
            {
                if (double.TryParse(dub, out double x))
                {
                    return true;
                }
                else return false;
            }
            void Area()
            {
                Console.Clear();
                string uLength;
                string uWidth;
                string uHeight;
                string uQuit;
                string quit;
                double length;
                double width;
                double height;
                double area;
                double perimeter;
                double volume;
                while (true)
                {
                    Console.WriteLine("Enter Length: ");
                    uLength = Console.ReadLine();
                    if(isDouble(uLength))
                    {
                        length = Convert.ToDouble(uLength);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number: ");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter width: ");
                    uWidth = Console.ReadLine();
                    if (isDouble(uWidth))
                    {
                        width = Convert.ToDouble(uWidth);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number: ");
                        continue;
                    }
                }
                area = length * width;
                perimeter = (2 * length) + (2 * width);
                Console.WriteLine($"Area:{area}" +
                                  $"\nPerimeter: {perimeter}");
                Console.WriteLine("Press any key to continue or q to quit");
                uQuit = Console.ReadLine();
                quit = uQuit.ToUpper();
                if (quit == "Q")
                {
                    return;
                }
                while (true)
                {
                    Console.WriteLine("Enter height: ");
                    uHeight = Console.ReadLine();
                    if (isDouble(uHeight))
                    {
                        height = Convert.ToDouble(uHeight);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number: ");
                        continue;
                    }
                }
                volume = length * width * height;
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine("Press R to restart or any key to quit");
                uQuit = Console.ReadLine();
                quit = uQuit.ToUpper();
                if (quit == "R")
                {
                    Area();
                }
                else
                {
                    return;
                }
                //hey

            }
            Area();
        }
    }
}

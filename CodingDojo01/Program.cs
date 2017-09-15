/*
 * Coding Dojo 01
 * Sabrina Pfeiffer
 * wi16b012
 */ 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string input;
            string value;
            double celsius = 0;
            double fahrenheit = 0; // = celsius * 1.8 + 32
            double reaumur = 0; //= celsius * 0.8
            double kelvin = 0; // = celsius + 273.15

            // introduction message
            Console.WriteLine("Welcome to the Temperature Converter!\nSelect you input type:");

            // iterate at least once until 0 is pressed
            do
            {
                // ask for input type
                Console.WriteLine("1 or C: Celsius");
                Console.WriteLine("2 or F: Fahrenheit");
                Console.WriteLine("3 or R: Reaumur");
                Console.WriteLine("4 or K: Kelvin");
                Console.WriteLine("0 Exit");

                // user enters number
                input = Console.ReadLine();
                           
                // switch
                switch (input)
                {
                    case "1":
                    case "C":
                        Console.WriteLine("Celsius choosen.\nenter decimal value:");
                        value = Console.ReadLine();
                        celsius = Convert.ToDouble(value);
                        fahrenheit = celsius * 1.8 + 32;
                        reaumur = celsius * 0.8;
                        kelvin = celsius + 273.15;
                        Console.WriteLine("{0} Celsius equals\n"
                                        + "{1} Fahrenheit\n"
                                        + "{2} Reaumur\n"
                                        + "{3} Kelvin", celsius, fahrenheit, reaumur, kelvin);
                        Console.WriteLine("Select again your input type:");
                        break;
                    case "2":
                    case "F":
                        Console.WriteLine("Fahrenheit choosen.\nenter decimal value:");
                        value = Console.ReadLine();
                        celsius = (Convert.ToDouble(value) - 32) / 1.8;
                        fahrenheit = celsius * 1.8 + 32;
                        reaumur = celsius * 0.8;
                        kelvin = celsius + 273.15;
                        Console.WriteLine("{0} Fahrenheit equals\n"
                                        + "{1} Celsius \n"
                                        + "{2} Reaumur\n"
                                        + "{3} Kelvin", fahrenheit, celsius, reaumur, kelvin);
                        Console.WriteLine("Select again your input type:");
                        break;
                    case "3":
                    case "R":
                        Console.WriteLine("Reaumur choosen.\nenter decimal value:");
                        value = Console.ReadLine();
                        celsius = Convert.ToDouble(value) / 0.8;
                        fahrenheit = celsius * 1.8 + 32;
                        reaumur = celsius * 0.8;
                        kelvin = celsius + 273.15;
                        Console.WriteLine("{0} Reaumur equals\n"
                                        + "{1} Celsius \n"
                                        + "{2} Fahrenheit\n"
                                        + "{3} Kelvin", reaumur, celsius, fahrenheit, kelvin);
                        Console.WriteLine("Select again your input type:");
                        break;
                    case "4":
                    case "K":
                        Console.WriteLine("Kelvin choosen.\nenter decimal value:");
                        value = Console.ReadLine();
                        celsius = Convert.ToDouble(value) - 273.15;
                        fahrenheit = celsius * 1.8 + 32;
                        reaumur = celsius * 0.8;
                        kelvin = celsius + 273.15;
                        Console.WriteLine("{0} Kelvin equals\n"
                                        + "{1} Celsius \n"
                                        + "{2} Fahrenheit\n"
                                        + "{3} Reaumur", kelvin, celsius, fahrenheit, reaumur);
                        Console.WriteLine("Select again your input type:");
                        break;
                    case "0":
                        Console.WriteLine("good bye!");
                        break;
                    default:
                        Console.WriteLine("invalid input, try again");
                        break;

                }
            } while (input != "0");

        }
    }
}

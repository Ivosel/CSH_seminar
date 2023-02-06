using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mathematical expression with distances (e.g. 1 km + 30 m):");
            string input = Console.ReadLine();

            // Split the input into separate distances, units and operators
            string[] distances = input.Split(' ');

            // Convert the distances to meters
            double result = 0;
            for (int i = 0; i < distances.Length; i++)
            {
                if (i % 3 == 0)
                {
                    double value = double.Parse(distances[i]);
                    string unit = distances[i + 1];
                    switch (unit)
                    {
                        case "km":
                            value *= 1000;
                            break;
                        case "cm":
                            value /= 100;
                            break;
                        case "mm":
                            value /= 1000;
                            break;
                    }

                    // Add or subtract the distance from the result
                    if (i > 0 && distances[i - 1] == "+")
                    {
                        result += value;
                    }
                    else if (i > 0 && distances[i - 1] == "-")
                    {
                        result -= value;
                    }
                    else
                    {
                        result = value;
                    }
                }
            }

            Console.WriteLine("Enter the unit to display the result (m, km, cm, mm):");
            string displayUnit = Console.ReadLine();
            switch (displayUnit)
            {
                case "km":
                    result /= 1000;
                    break;
                case "cm":
                    result *= 100;
                    break;
                case "mm":
                    result *= 1000;
                    break;
            }

            Console.WriteLine("Result: " + result + " " + displayUnit);
            Console.ReadKey();
        }
    }
}

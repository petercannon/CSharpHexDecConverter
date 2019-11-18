using System;

namespace Decimal_To_Hexidecimal_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            string input = "";
            int decimalNumber = 0;
            string hexNumber = "";
            Console.WriteLine("Hexadecimal/Decimal Converter");
            Console.WriteLine("=============================\n");
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Dec to Hex");
                Console.WriteLine("2. Hex to Dec");
                Console.WriteLine("3. Quit");
                Console.WriteLine("--------------");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("Enter a decimal number to convert to hexidecimal: ");
                    input = Console.ReadLine();
                    decimalNumber = int.Parse(input);
                    // Decimal to Hexadecimal
                    hexNumber = decimalNumber.ToString("X");
                    Console.WriteLine($"The hexadecimal value for {decimalNumber} is {hexNumber}\n");
                }
                else if (option == "2")
                {
                    Console.Write("Enter a hexidecimal number to convert to decimal: ");
                    hexNumber = Console.ReadLine();
                    // Hexadecimal to Decimal
                    decimalNumber = Convert.ToInt32(hexNumber, 16);
                    Console.WriteLine($"The decimal value for {decimalNumber} is {hexNumber}\n");
                }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }            

        }
    }
}

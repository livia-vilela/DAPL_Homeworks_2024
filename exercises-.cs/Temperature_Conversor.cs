/* 
This program performs temperature conversions between Celsius and Fahrenheit. 
The user selects the desired conversion type, inputs the temperature, 
and the program calculates and displays the converted value.
*/

using System;

class Temperature_Conversor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which conversion would you like to do? \n1) Celsius -> Fahrenheit \n2) Fahrenheit -> Celsius");
        int option = int.Parse(Console.ReadLine());
        if (option < 1 || option > 2)
        {
            Console.WriteLine("This isn't a valid option. Try again.");
        }
        else if ( option == 1)
        {
            Console.Write("Type the Celsius temperature: ");
            double celsius = double.Parse(Console.ReadLine());
            double result_f = (1.8*celsius) + 32;
            Console.WriteLine("{0}°C in Fahrenheit is {1}°F.", celsius, result_f);
        }
        else
        {
            Console.Write("Type the Fahrenheit temperature: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double result_c = (fahrenheit-32)/1.8;
            Console.WriteLine("{0}°F in Celsius is {1}°C.", fahrenheit, result_c.ToString("F2"));
        }
    }
}
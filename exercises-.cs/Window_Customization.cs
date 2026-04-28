/* 
The task is to create a console application that allows the user to 
customize the background color of the console window. The user should 
be able to choose from a predefined set of colors, and the application 
should apply the selected color to the console background.
*/

using System;
using System.Reflection.PortableExecutable;
class Window_Customization
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type the number of the chosen color: ");
        Console.WriteLine("1) Green");
        Console.WriteLine("2) Cyan");
        Console.WriteLine("3) Magenta");
        int color = Convert.ToInt16(Console.ReadLine());

        if(color == 1)
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        else if(color == 2)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;

        }
        else if(color == 3)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
    }
}
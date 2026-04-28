/* 
This program converts a number between 0 and 15, entered by the user, 
into its English word equivalent. If the input is outside the valid range, 
it displays an error message.
*/

using System;
class English_Number
{
    static void Main(string[] args)
    {
        Console.Write("Type a number from 0 to 15: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0 || number > 15)
        {
            Console.WriteLine("The number doesn't match the parameters. Try again...");
        }
        else
        {
            Console.Write(number + " = " + English_Number.numberToWord(number));
        }
    }
    private static string numberToWord(int number)
    {
        string[] english = { "zero", "one", "two", "three", "four",
                             "five", "six", "seven", "eight", "nine",
                             "ten", "eleven", "twelve", "thirteen",
                             "fourteen", "fifteen" };
        return english[number];
    }

}

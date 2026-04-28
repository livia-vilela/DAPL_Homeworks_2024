/* 
This program generates a specified quantity of random numbers within a 
user-defined range. It validates the input values to ensure the range and 
quantity are appropriate, then displays the generated numbers.
*/

using System;

class Random_Number_Generator
{
    static void Main(string[] args)
    {
        Console.Write("This is a Random Number Generator.\nEnter with the minimum value: ");
        int min_value = int.Parse(Console.ReadLine());
        Console.Write("Enter with the maximum value: ");
        int max_value = int.Parse(Console.ReadLine());
        Console.Write("Enter with how many numbers do you want to generate: ");
        int quantity = int.Parse(Console.ReadLine());

        if (min_value >= max_value || quantity == 0)
        {
            Console.WriteLine("The entered values are not appropiate. Try again...");
        }
        else
        {
            int[] numbers = new int[quantity];
            Random random = new Random();

            for (int i = 0; i < quantity; i++)
            {
                numbers[i] = random.Next(min_value, max_value + 1);
            }

            Console.Write("Generated numbers: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
/*
This program prompts the user to input 10 numbers, sorts them, 
and allows the user to choose whether to display the numbers in 
ascending or descending order.
*/

using System;

class Number_Sorter
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter with 10 numbers to sort: ");
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine("Which way would you like to sort the numbers: \n > 1. Ascending \n > 2. Descending");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Array.Sort(numbers);
                Console.WriteLine("\nAscending: \n");
                foreach (int ascending_sort in numbers)
                {
                    Console.WriteLine(ascending_sort);
                }
                break;
            case 2:
                Array.Reverse(numbers);
                Console.WriteLine("\nDescending: \n");
                foreach (int descending_sort in numbers)
                {
                    Console.WriteLine(descending_sort);
                }
                break;
        }


    }
}
/* 
This program calculates the Body Mass Index (BMI) based on 
the user's height and weight. It then categorizes the BMI 
into different weight classifications, such as underweight, 
normal weight, overweight, and various obesity grades, 
and displays the result.
*/

using System;

class BMI_Index
{
    static void Main(string[] args)
    {
        Console.Write("Enter with the height in meters: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter with the weight in KG: ");
        double weight = double.Parse(Console.ReadLine());
        double bmi = weight/(height*height);
        if (bmi < 18.5)
        {
            Console.WriteLine("The BMI is: {0}. Underweight.", bmi.ToString("F1"));

        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("The BMI is: {0}. Normal Weight.", bmi.ToString("F1"));
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("The BMI is: {0}. Overweight.", bmi.ToString("F1"));
        }
        else if (bmi >= 30 && bmi < 35)
        {
            Console.WriteLine("The BMI is: {0}. Grade 1 Obesity.", bmi.ToString("F1"));
        }
        else if (bmi >= 35 && bmi < 40)
        {
            Console.WriteLine("The BMI is: {0}. Grade 2 Obesity.", bmi.ToString("F1"));
        }
        else 
        {
            Console.WriteLine("The BMI is: {0}. Grade 3 Obesity.", bmi.ToString("F1"));
        }
    }
}
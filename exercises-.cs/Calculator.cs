/* 
This program functions as a basic calculator. It prompts the user to 
input two numbers and select an operation (sum, subtraction, multiplication,
or division). Based on the selected operation, it performs the calculation 
and displays the result. If an invalid option is chosen, it notifies the user.
*/

using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Type the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Type the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Choose the operation:\n1. Sum \n2. Subtraction \n3. Multiplication \n4. Division");
        int operation = int.Parse(Console.ReadLine());

        switch (operation) {

            case 1:
                
             double sum_result = num1 + num2;
             Console.WriteLine("The sum result is = {0}", sum_result);
            break;

            case 2:
                
             double subtraction_result = num1 - num2;
             Console.WriteLine("The subtraction result is = {0}", subtraction_result);
            break;
            case 3:
                
             double multiplication_result = num1 * num2;
             Console.WriteLine("The multiplication result is = {0}", multiplication_result);
            break;
            case 4:
              
             double division_result = num1 / num2;
             Console.WriteLine("The division result is = {0}", division_result);
            break;

            default:
                    Console.WriteLine("This isn't an option. Try again...");
            break;

        }


    }

}

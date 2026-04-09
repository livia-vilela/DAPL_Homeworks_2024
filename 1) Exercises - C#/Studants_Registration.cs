/* 
This program collects a student's name, registration number, 
and birth date from user inputand confirms the registration 
with a success message.
*/

using System;

class Studants_Register

{
    static void Main(string[] args)
    {
        Console.WriteLine("Studant Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Studant Registration: ");
        int registration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Studant Birth Date: ");
        string birth_date = Console.ReadLine();
        Console.WriteLine("\nRegistration done sucessfully!");
    }
}

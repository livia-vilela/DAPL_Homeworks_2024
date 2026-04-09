/* 
This program collects five names from user input, stores them in an array, 
and displays the names in a formatted list separated by commas, 
ending with a period.
*/

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
class Names_Array

{
    static void Main(string[] args)
    {
        Console.WriteLine("Type 5 names (Press Enter after typing a name):");
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();
        string name4 = Console.ReadLine();
        string name5 = Console.ReadLine();
        string[] names = { name1, name2, name3, name4, name5 };
        
        Console.WriteLine("The typed names are: ");

        for (int i = 0; i < names.Length; i++)
        {
            if (i < 4)
            {
                Console.Write(names[i] + ", ");
            }
            else
            {
                Console.Write(names[4] + ".");
            }
        }
    }
}

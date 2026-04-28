/* 
This program prompts the user to input two names, displays them 
in a formatted manner, and prints a static string "34DS - 2024" 
to the console.
*/

using System;
class Name_Reader
{

    static void Main(string[] args){
        Console.WriteLine("Type the members' names: ");
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        Console.WriteLine(name1 + ", " + name2);
        Console.WriteLine("34DS - 2024");

        
    }


}


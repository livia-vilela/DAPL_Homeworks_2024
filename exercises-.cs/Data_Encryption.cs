/* 
This program collects the user's name, city, and year of birth from console input,
combines this information into a formatted string, and calculates its hash code.
It then writes both the original information and its hash code to a text file 
named "info.txt", overwriting the file if it already exists.
*/

using System;
using System.IO;
using System.Text;
class Data_Encryption
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Type your city: ");
        string city = Console.ReadLine();
        Console.WriteLine("Type the year that you where born: ");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        string data = Convert.ToString("Name: " + name + "\n" + "City: " + city + "\n" + "Birth Year: " + birth_year);
        string path = @"../../../info.txt";

        int hash = data.GetHashCode();

        if (File.Exists(path) == true)
        {
            File.Delete(path);
        }
        string title1 = "*xxx  Info without Hash  xxx*";
        string title2 = "*xxx  Info with Hash  xx*";
        string path_text = "The file is placed in the code's main folder"; 
        File.WriteAllText(path, title1 + "\n" + data + "\n\n" + title2 + "\n" + hash + "\n\n" + path_text);

    }
    
}

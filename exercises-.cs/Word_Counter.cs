/* 
This program counts the number of words in a user-provided text. 
It splits the text into words using various delimiters 
(e.g., spaces, punctuation) and displays the total word count.
*/

using System;

class Word_Counter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the word counter!\n\n > Insert your text here: ");
        string text = Console.ReadLine();
        char[] separators = { ' ', '.', ',', ';', '?', '-', '!', ':', '\n' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\n\n > The total number of words is {0}", words.Length);
    }
}
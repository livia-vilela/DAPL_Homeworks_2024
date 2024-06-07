using System;
using System.Reflection.PortableExecutable;
class Customizacao_Janela
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número da cor de sua preferência: ");
        Console.WriteLine("1) verde");
        Console.WriteLine("2) ciano");
        Console.WriteLine("3) magenta");
        int cor = Convert.ToInt16(Console.ReadLine());

        if(cor == 1)
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        else if(cor == 2)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;

        }
        else if(cor == 3)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
    }
}
using System;

class Contador
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Contador de Palavras!\n\n > Insira seu texto aqui: ");
        string texto = Console.ReadLine();
        char[] separadores = { ' ', '.', ',', ';', '?', '-', '!', ':', '\n' };
        string[] palavras = texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\n\n > O número total de palavras é {0}", palavras.Length);
    }
}
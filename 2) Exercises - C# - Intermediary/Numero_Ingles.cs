using System;
class Numero_Ingles
{
    static void Main(string[] args)
    {
        Console.Write("Digite um  número inteiro de 0 a 15: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0 || numero > 15)
        {
            Console.WriteLine("O número não se insere nos parâmetros exigidos. Tente com outro número.");
        }
        else
        {
            Console.Write(numero + " = " + number(numero));
        }
    }
    private static string number(int num)
    {
        string[] english = { "zero", "one", "two", "three", "four", "five", "siz", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen" };
        return english[num];
    }
 
}

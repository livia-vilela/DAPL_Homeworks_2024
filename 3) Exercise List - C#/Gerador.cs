using System;

class Gerador
{
    static void Main(string[] args)
    {
        Console.Write("Esse é um gerador de números inteiros aleatórios.\nIndique aqui, o valor mínimo desejado: ");
        int valor_min = int.Parse(Console.ReadLine());
        Console.Write("Indique o valor máximo desjado: ");
        int valor_max = int.Parse(Console.ReadLine());
        Console.Write("Indique a quantidades de números aleatórios que você deseja: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        if ( valor_min >= valor_max || quantidade == 0)
        {
            Console.WriteLine("Os valores inseridos não se aplicam, tente novamente.");
        }
        else
        {
            for (int i = 0; i < quantidade; i++)
            {
                Random random = new Random();
                int numero = random.Next(valor_min, valor_max +1);
                Console.Write("Os números gerados foram: " + numero + " ");

            }
        }
    }

}

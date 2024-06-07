using System;

class Ordenador
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite os 10 números que você deseja ordenar (separe-os com um enter). ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());
        int num6 = int.Parse(Console.ReadLine());
        int num7 = int.Parse(Console.ReadLine());
        int num8 = int.Parse(Console.ReadLine());
        int num9 = int.Parse(Console.ReadLine()); 
        int num10 = int.Parse(Console.ReadLine());

        int[] numeros = {num1 ,num2 ,num3 ,num4 , num5 ,num6 ,num7 , num8 , num9, num10 };
        Array.Sort(numeros);

        Console.WriteLine("Você deseja ordená-los em: \n > 1. Ordem Crescente \n > 2. Ordem Decrescente");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Array.Sort(numeros);
                Console.WriteLine("\nOrdem crescente dos números digitados: \n");
                foreach (int ordem_crescente in numeros)
                {
                    Console.WriteLine(ordem_crescente);
                }
            break;
            case 2:
                Array.Reverse(numeros);
                Console.WriteLine("\nOrdem decrescente dos números digitados: \n");
                foreach (int ordem_decrescente in numeros)
                {
                    Console.WriteLine(ordem_decrescente);
                }
            break;
        }


    }
}
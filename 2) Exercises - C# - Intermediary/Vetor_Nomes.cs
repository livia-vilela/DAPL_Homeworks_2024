using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
class Vetor_Nomes

{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite 5 nomes separados por enter:");
        string nome1 = Console.ReadLine();
        string nome2 = Console.ReadLine();
        string nome3 = Console.ReadLine();
        string nome4 = Console.ReadLine();
        string nome5 = Console.ReadLine();
        string[] nomes = { nome1, nome2, nome3, nome4, nome5 };
        
        Console.WriteLine("Os nomes digitados foram: ");

        for (int i = 0; i < nomes.Length; i++)
        {
            if (i < 4)
            {
                Console.Write(nomes[i] + ", ");
            }
            else
            {
                Console.Write(nomes[4] + ".");
            }
        }
    }
}

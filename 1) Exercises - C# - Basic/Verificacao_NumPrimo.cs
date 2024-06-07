class Verificacao_NumPrimo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num==0)
        {
            Console.WriteLine("Esse número não é primo.");
        }
        else if (num==1)
        {
            Console.WriteLine("Esse número não é primo.");
        }
        else if (num==2)
        {
            Console.WriteLine("Esse número é primo.");
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Esse Número não é primo.");

                }
                else
                {
                    Console.WriteLine("Esse número é primo.");

                }
                break;
            }
        }


        
    }


}
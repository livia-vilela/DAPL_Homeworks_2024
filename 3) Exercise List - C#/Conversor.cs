using System;

class Conversor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indique a conversão que você deseja fazer: \n1) Celsius -> Fahrenheit \n2) Fahrenheit -> Celcius");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao < 1 || opcao > 2)
        {
            Console.WriteLine("Essa opção não está disponível. Tente novamente.");
        }
        else if ( opcao == 1)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double result_f = (1.8*celsius) + 32;
            Console.WriteLine("{0}°C em Fahrenheit é {1}°F.", celsius, result_f);
        }
        else
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double result_c = (fahrenheit-32)/1.8;
            Console.WriteLine("{0}°F em celsius é {1}°C.", fahrenheit, result_c.ToString("F2"));
        }
    }
}
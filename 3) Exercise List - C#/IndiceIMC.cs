using System;

class IndiceIMC
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Informe seu peso em Kg: ");
        double peso = double.Parse(Console.ReadLine());
        double imc = peso/(altura*altura);
        if (imc < 18.5)
        {
            Console.WriteLine("O IMC é: {0}. Você está abaixo do peso.", imc.ToString("F1"));

        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("O IMC é: {0}. Você está com o peso normal.", imc.ToString("F1"));
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("O IMC é: {0}. Você está com sobrepeso.", imc.ToString("F1"));
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("O IMC é: {0}. Você está com obesidade grau 1.", imc.ToString("F1"));
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("O IMC é: {0}. Você está com obesidade grau 2.", imc.ToString("F1"));
        }
        else 
        {
            Console.WriteLine("O IMC é: {0}. Você está com obesidade grau 3.", imc.ToString("F1"));
        }
    }
}
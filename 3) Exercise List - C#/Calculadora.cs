using System;

class Calculadora
{
    static void Main(string[] args)
    {
        Console.Write("Digite aqui o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite aqui o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escolha a operação que deseja usar:\n1. Adição \n2. Subtração \n3. Multiplicação \n4. Divisão");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao) {

            case 1:
                
             double resultado_soma = num1 + num2;
             Console.WriteLine("O resultado da soma é: {0}", resultado_soma);
            break;

            case 2:
                
             double resultado_subtracao = num1 - num2;
             Console.WriteLine("O resultado da subtração é: {0}", resultado_subtracao);
            break;
            case 3:
                
             double resultado_multiplicacao = num1 * num2;
             Console.WriteLine("O resultado da multiplicação é: {0}", resultado_multiplicacao);
            break;
            case 4:
              
             double resultado_divisao = num1 / num2;
             Console.WriteLine("O resultado da divisão é: {0}", resultado_divisao);
            break;

            default:
                    Console.WriteLine("Essa não é uma opção, tente novamente.");
            break;

        }


    }

}

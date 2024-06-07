using System;

class Cadastro_Alunos

{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite,usando enter para separar as informações o nome do aluno, o número da matrícula e a data de nascimento: ");
        string nome = Console.ReadLine();
        int matricula = Convert.ToInt32(Console.ReadLine());
        string nasc = Console.ReadLine();
        Console.WriteLine("\nSeu cadastro foi concluído com sucesso!");
    }
}

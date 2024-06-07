using System;
using System.IO;
using System.Text;
class Criptografia_Dados
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe sua cidade: ");
        string cidade = Console.ReadLine();
        Console.WriteLine("Informe seu ano de nascimento: ");
        int nasc = Convert.ToInt16(Console.ReadLine());

        string dados = Convert.ToString("Nome: " + nome + "\n" + "Cidade: " + cidade + "\n" + "Ano de nascimento: " + nasc);
        string path = @"../../../info.txt";

        int hash = dados.GetHashCode();

        if (File.Exists(path) == true)
        {
            File.Delete(path);
        }
        string titulo1 = "*xxx  Info sem Hash  xxx*";
        string titulo2 = "*xxx  Info com Hash  xx*";
        string local = "O arquivo está localizado na pasta principal do código"; 
        File.WriteAllText(path, titulo1 + "\n" + dados + "\n\n" + titulo2 + "\n" + hash + "\n\n" + local);

    }
    
}

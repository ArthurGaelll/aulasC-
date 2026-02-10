using System;

class aula13
{
    static void Main()
    {
        
        int n1, n2, n3, n4, res;
        string resultado;

        Console.WriteLine("Escreva a primeira nota:");
        n1 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Escreva a segunda nota:");
        n2 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Escreva a terceira nota:");
        n3 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Escreva a quarta nota:");
        n4 = int.Parse(Console.ReadLine() ?? "0");

        res = n1 + n2 + n3 + n4;

        if (res < 40)
        {
            resultado = "Reprovado";
        }
        else if (res < 60)
        {
            resultado = "Recuperação";
        }
        else
        {
            resultado = "Aprovado";
        }

        
        Console.WriteLine("Nota total: {0} - Resultado: {1}", res, resultado);
    }
}
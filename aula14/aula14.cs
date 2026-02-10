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

        // >=60 - Aprovado
        //59 e 40 - Recuperação
        //<40 = Reprovado

        if (res >= 60)
        {
            if(res >= 90)
            {
                resultado = "Aprovado com louvor";
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (res >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
        }

        
        Console.WriteLine("Nota total: {0} - Resultado: {1}", res, resultado);
    }
}
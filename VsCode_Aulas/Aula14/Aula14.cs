//Video Aula 14: https://youtu.be/BR8_SLFAoaM

using System;

class Aula14
{
    static void Main()
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        string result = "Reprovado";

        Console.Write("Digite a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if (res >= 6)
        {
            if (res >= 9)
            {
                result = "Aprovado com louvor";
            }
            result = "Aprovado";
        }
        else
        {
            if (res >= 4)
            {
                result = "Recuperação";
            }
            result = "Reprovado";
        }

        Console.WriteLine("Média " + res + "\nSituação: " + result);
    }
}
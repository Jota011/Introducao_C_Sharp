//Video Aula 12: https://youtu.be/m_0y_k-sCcI

using System;

class Aula12
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
            result = "Aprovado";
        }

        Console.WriteLine("Média "+ res +"\nSituação: " + result);
    }
}
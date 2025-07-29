//Video Aula 13: https://youtu.be/Ojm98Gg1rVw

using System;

class Aula13
{
    static void Main()
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        string result;

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
        }else if (res >= 4)
        {
            result = "Recuperação";
        }
        else
        {
            result = "Reprovado";
        }

        Console.WriteLine("Média "+ res +"\nSituação: " + result);
    }
}
//Video Aula 04 - https://youtu.be/1tsK4u4Hmck

using System;

class Aula04
{
    static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 20;
        Test(n1, n2);
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
    static void Test(int n1, int n2)
    {
        int r1 = n1 + n2; //soma
        int r2 = n1 - n2; //subtração
        int r3 = n1 * n2; //multiplicação
        int r4 = n1 / n2; //divisão
        int r5 = n1 % n2; //resto da divisão

        Console.WriteLine("Soma: " + r1);
        Console.WriteLine("Subtração: " + r2);
        Console.WriteLine("Multiplicação: " + r3);
        Console.WriteLine("Divisão: " + r4);
        Console.WriteLine("Resto da Divisão: " + r5);
    }
    //Método Test recebe dois parâmetros inteiros e realiza operações aritméticas
    //e exibe os resultados no console.
}
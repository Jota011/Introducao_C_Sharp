//Video Aula 15: https://youtu.be/dgEYyIAq-h4

using System;

class Aula15
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Escreva um numero de 1 a 3: ");
        numero = int.Parse(Console.ReadLine());
        switch (numero)
        {
            case 1:
                Console.WriteLine("Você escolheu o número 1");
                break;
            case 2:
                Console.WriteLine("Você escolheu o número 2");
                break;
            case 3:
                Console.WriteLine("Você escolheu o número 3");
                break;
            default:
                Console.WriteLine("Número inválido, escolha entre 1 e 3.");
                break;

        }
    }
}
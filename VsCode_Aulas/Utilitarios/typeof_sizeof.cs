//Video Aula 6: https://youtu.be/BVNhK3lQyww
using System;

class Aula06
{
    static void Main(string[] args)
    {
        //Operadores de tipo:
        // typeof (obtém o tipo de uma variável)
        // sizeof (obtém o tamanho em bytes de um tipo)
        // checked (verifica estouro de aritmética)
        // unchecked (não verifica estouro de aritmética)

        //Exemplo de uso do operador typeof:
        Type tipo = typeof(int);
        Console.WriteLine("O tipo int é: " + tipo);

        //Exemplo de uso do operador sizeof:
        int tamanho = sizeof(int);
        Console.WriteLine("O tamanho do tipo int é: " + tamanho + " bytes");

        //Exemplo de uso do operador checked:
        try
        {
            checked
            {
                int max = int.MaxValue;
                max += 1; // Isso causará uma exceção de estouro
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        //Exemplo de uso do operador unchecked:
        unchecked
        {
            int max = int.MaxValue;
            max += 1; // Isso não causará uma exceção, mas resultará em um valor incorreto
            Console.WriteLine("Valor após unchecked: " + max);
        }
    }
}
//Video Aula 11: https://youtu.be/ucGefp2i4As
using System;

class Aula11
{
    static void Main()
    {
        //Conversao implícita
        int n1 = 10;
        float n2 = n1;
        Console.WriteLine(n2);

        //Converção explícita
        float n3 = 10.7f;
        int n4 = (int)n3;
        Console.WriteLine(n4);
    }
}
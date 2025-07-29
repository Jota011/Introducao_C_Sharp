//Video Aula 10: https://youtu.be/kj_-Brm4DDI

using System;

class Aula10
{
    enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
    static void Main()
    {
        //DiasSemana ds = 3; // Ocorre um erro de compilação, pois o valor 3 não é do tipo DiasSemana
        //DiasSemana ds = (DiasSemana)3; // Quarta
        DiasSemana ds = DiasSemana.Quarta;

        Console.WriteLine("Hoje é: " + ds);
        Console.WriteLine("Número do dia: " + (int)ds);

        //Outro modelo é:

        int diaS = (int)DiasSemana.Quarta; //Ele converte o DiasSemana.Quarta para o inteiro correspondente
        Console.WriteLine("Número do dia: " + diaS);



    }
}
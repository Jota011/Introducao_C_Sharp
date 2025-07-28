// See https://aka.ms/new-console-template for more information
// Video aula: https://youtu.be/25gWhVRRYDI
using System;

class Aula03
{
    //Se a variavel for colocada do lado de fora do Main(Ou classes em geral) ela se torna uma variavel global
    int variavelGlobal = 10; //variavel global (pode ser acessada por qualquer metodo da classe)
    static void Main()
    {
        //Se antes da variavel colocarmos [] ela se torna um array
        int inteiro = 2;                //variavel do tipo inteiro (32 bits)
        double real = 3.14;             //variavel do tipo double (precisão dupla)
        float real2 = 3.14f;            //variavel do tipo float (precisão simples)
        decimal real3 = 3.14m;          //variavel do tipo decimal (precisão alta)
        char caractere = 'A';           //variavel do tipo char (caractere único)
        string texto = "texto_2004";    //variavel do tipo string (sequencia de caracteres)
        bool logico = true;             //variavel do tipo booleano (Verdadeiro ou Falso)

        var inteiroVariavel = 10;                   //variavel do tipo var (inferência de tipo, neste caso é int, mas pode ser de qualquer outro tipo)
        var caractereVariavel = "dez";              //variavel do tipo var (na atribuição que ira definir o tipo da variavel)
        const string canal = "CBF curso";           //variavel constante (não pode ser alterada após a definição)

        long inteiroGrande = 1234567890123456789L;                  //variavel do tipo long (64 bits)
        short inteiroPequeno = 12345;                               //variavel do tipo short (16 bits)
        byte inteiroMuitoPequeno = 255;                             //variavel do tipo byte (8 bits)
        sbyte inteiroPequenoComSinal = -128;                        //variavel do tipo sbyte (-128 a 127)
        uint inteiroSemSinal = 4294967295U;                         //variavel do tipo (unsigned) inteiro sem sinal (32 bits)
        ulong inteiroMuitoGrandeSemSinal = 18446744073709551615UL;  //variavel do tipo ulong (64 bits sem sinal)
        ushort inteiroPequenoSemSinal = 65535;                      //variavel do tipo ushort (16 bits sem sinal)
        object objeto = "Isto e um objeto";                         //variavel do tipo object (pode armazenar qualquer tipo de dado)
        dynamic dinamico = "Isto e dinamico";                       //variavel do tipo dynamic (pode mudar de tipo em tempo de execução)
        DateTime dataHora = DateTime.Now;                           //variavel do tipo DateTime (data e hora)
        TimeSpan duracao = new TimeSpan(1, 2, 3);                   //variavel do tipo TimeSpan (duração de tempo)
        Guid identificadorUnico = Guid.NewGuid();                   //variavel do tipo Guid (identificador único global)


        Console.WriteLine("Variáveis definidas:");
        Console.WriteLine($"Inteiro: {inteiro}");
        Console.WriteLine($"Double: {real}");
        Console.WriteLine($"Float: {real2}");
        Console.WriteLine($"Decimal: {real3}");
        Console.WriteLine($"Caractere: {caractere}");
        Console.WriteLine($"String: {texto}");
        Console.WriteLine($"Booleano: {logico}");
        Console.WriteLine($"Variável Inteiro (var): {inteiroVariavel}");
        Console.WriteLine($"Variável Caractere (var): {caractereVariavel}");
        Console.WriteLine($"Long: {inteiroGrande}");
        Console.WriteLine($"Short: {inteiroPequeno}");
        Console.WriteLine($"Byte: {inteiroMuitoPequeno}");
        Console.WriteLine($"SByte: {inteiroPequenoComSinal}");
        Console.WriteLine($"UInt: {inteiroSemSinal}");
        Console.WriteLine($"ULong: {inteiroMuitoGrandeSemSinal}");
        Console.WriteLine($"UShort: {inteiroPequenoSemSinal}");
        Console.WriteLine($"Object: {objeto}");
        Console.WriteLine($"Dynamic: {dinamico}");
        Console.WriteLine($"Data e Hora: {dataHora}");
        Console.WriteLine($"Duração: {duracao}");
        Console.WriteLine($"Identificador Unico: {identificadorUnico}");


        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

    }
} 

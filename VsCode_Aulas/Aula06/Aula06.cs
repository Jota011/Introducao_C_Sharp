//Video Aula 6: https://youtu.be/BVNhK3lQyww
using System;

class Aula06
{
    static void Main(string[] args)
    {
        double vlCompra = 5.50;
        double vlVenda;
        double lucro = 0.1;
        string produto = "Pasteis";

        vlVenda= vlCompra + (vlCompra * lucro);

        Console.WriteLine("Produto.......{0,15}", produto); // Formatação de string{0} - com alinhamento {,15}
        Console.WriteLine("Val.Compra....{0,15:c}", vlCompra);  // (:c) - Formatação de moeda
        Console.WriteLine("Lucro.........{0,15:p}", lucro);     // (:p) - Formatação de porcentagem
        Console.WriteLine("Venda.........{0,15:c}", vlVenda);   // (:c) - Formatação de porcentagem
        
    }
}
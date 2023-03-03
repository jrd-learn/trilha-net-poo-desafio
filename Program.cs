using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// *IMPLEMENTADO*
internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("5511999554433", "Nokia 3310", "NK3310", 2);
        
        Console.WriteLine("Smartphone: Nokia");
        Console.WriteLine();
        Console.WriteLine(nokia);

        nokia.InstalarAplicativo("Gerenciador de ligações");
        nokia.Ligar();

        Console.WriteLine();
        Console.WriteLine();
        
        Smartphone iphone = new Iphone("5511988224130", "Iphone ZXW", "ZXW123456", 5);

        Console.WriteLine("Smartphone: Iphone");
        Console.WriteLine();
        Console.WriteLine(iphone);

        iphone.InstalarAplicativo("Gerenciador de ligações");
        iphone.ReceberLigacao();

    }
}
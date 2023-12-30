using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia1100 = new Nokia (numero:"31 91478954",modelo: "1100", imei:"12345698742",memoria: 32);
        nokia1100.Ligar();
        nokia1100.ReceberLigacao();
        nokia1100.InstalarAplicativo("Lonjong");

        Console.WriteLine("");
        Console.WriteLine("Smartphone Iphone");
        Smartphone iPhone13 = new Iphone (numero:"31 978452781",modelo: "13", imei:"985474125876",memoria: 128);
        iPhone13.Ligar();
        iPhone13.ReceberLigacao();
        iPhone13.InstalarAplicativo("Banco do Brasil");
    }

    
}
using System;
using System.Globalization;

class Program

{
    static void Main(string[] args)
    {
        ///condicionais pt.1
        Console.WriteLine("Qual a hora atual?");

        int hora = int.Parse(Console.ReadLine());
        if (hora < 12)
            Console.WriteLine("Bom dia!");
        else if (hora < 18)
            Console.WriteLine("Boa tarde!");
        else { Console.WriteLine("Boa noite !"); }

    }

}
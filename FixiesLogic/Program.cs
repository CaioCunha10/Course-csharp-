using System;
using System.Globalization;

class Program 

{
    static void Main(string[] args)
    {
        Console.WriteLine("entre com seu nome completo");
        string fullName = Console.ReadLine();

        int bedrooms = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com seu preço de produto");

        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre seu último nome, idade e altura (na mesma linha)");

        string[] vect = Console.ReadLine().Split(' ');
        string lastName = vect[0];
        int age = int.Parse(vect[1]);
        double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

        Console.WriteLine(fullName);
        Console.WriteLine(bedrooms);
        Console.WriteLine(price.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

    }
}
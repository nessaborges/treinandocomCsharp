using System;

class exer2
{
    static void Main()
    {
        int n1, n2, result;

        Console.Write("Digite um numero:");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro numero:");
        n2 = int.Parse(Console.ReadLine());

        result = (n1 + n2);

        Console.WriteLine("O Resultado da soma é:" + result);

    }
}
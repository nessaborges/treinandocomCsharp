using System;

class exer3
{
    static void Main()
    {
        int numdigitado;
        int result;

        Console.Write("Digite um numero:");
        numdigitado = int.Parse(Console.ReadLine());

        result = numdigitado+1;

        Console.WriteLine("O seu sucessor é:" + result);
    }
}
using System;

class exer4
{
    static void Main()
    {
        int nota1, nota2;
        float media;

        Console.Write("digite sua primeira nota:");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("digite sua segunda nota:");
        nota2 = int.Parse(Console.ReadLine());

        media = ((nota1+nota2)/2);

        Console.WriteLine("Sua média é:" + media);



    }
}
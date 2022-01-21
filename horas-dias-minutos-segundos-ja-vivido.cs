using System;

class exer
{
    static void Main()
    {
        int idade;
        int dias;
        int horas;
        int minutos;
        int segundos;

        Console.Write("Digite sua idade");
        idade = int.Parse(Console.ReadLine());
        dias = idade * 365;
        horas = dias * 24;
        minutos = horas * 60;
        segundos = minutos * 60;

        Console.WriteLine("dias:" + dias);
        Console.WriteLine("horas:" + horas);
        Console.WriteLine("minutos:"+ minutos);
        Console.WriteLine("segundos:" + segundos);

    }
}
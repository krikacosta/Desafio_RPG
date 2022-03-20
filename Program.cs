using System;
using Desafio_RPG.src.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Cristina = new Wizard("Cristina", 99, "White Wizard");
            Hero Beto = new Hero("Beto", 999, "Big Head");

            Console.WriteLine(Arus);
            Console.WriteLine(Cristina);
            Console.WriteLine(Beto);

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Cristina.Attack(5));
            Console.WriteLine(Cristina.Attack(10));
            Console.WriteLine(Beto.Attack());
        }
    }
}
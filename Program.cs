using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitarra minhaGuitarra = new Guitarra();
            minhaGuitarra.tocar();
            minhaGuitarra.tocar("DÓ");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
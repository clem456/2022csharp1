using System;
using System.Diagnostics;
using System.IO.Pipes;

namespace PropertyOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persoon persoon = new Persoon();

            persoon.Naam = "clement";//maak deze string aan als property in persoon, gebruik get set
            persoon.Leeftijd = 16;//maak deze int aan als property in persoon, gebruik get set

            Console.WriteLine($"mijn naam is {persoon.Naam} en ik ben {persoon.Leeftijd} jaar oud");
        }
    }
}
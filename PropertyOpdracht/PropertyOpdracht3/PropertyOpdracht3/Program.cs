using System;
using System.ComponentModel.Design;

namespace PropertyOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Mens mens = new Mens(15);

            mens.Leeftijd++;//deze moet werken

            Console.WriteLine($"Mijn leeftijd moet 16 zijn: {mens.Leeftijd}");

            mens.Leeftijd--;//deze mag niet werken

            Console.WriteLine($"Mijn leeftijd moet hetzelfde blijven: {mens.Leeftijd}");
        }
    }
}
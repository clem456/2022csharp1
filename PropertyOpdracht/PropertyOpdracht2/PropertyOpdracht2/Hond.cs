using System.Dynamic;

namespace PropertyOpdracht1
{
    internal class Hond
    {
        internal string Naam { get; private set; } //maak hier een property Naam, de set moet private zijn!
        public Hond(string naam)
        {
            this.Naam = naam;
        }

    }
}
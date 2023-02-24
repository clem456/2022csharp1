using System;

namespace VariableOpdracht2
{
    internal class Game
    {
        internal string name;

        internal Game(string name)//constructor
        {
            this.name = name;
        }

        public static implicit operator Game(string v)
        {
            throw new NotImplementedException();
        }
    }
}
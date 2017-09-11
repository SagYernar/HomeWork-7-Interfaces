using System;

namespace ConsoleApp10
{
    public class Wall : IPart
    {
        public Wall()
        {
            IsBuilded = false;
            Symbol = '#';
        }
        public bool IsBuilded
        {
            get;

            set;
        }

        public char Symbol
        {
            get;

            set;
        }
    }
}
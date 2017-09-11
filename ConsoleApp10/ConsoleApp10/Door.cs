using System;

namespace ConsoleApp10
{
    public class Door: IPart
    {
        public Door()
        {
            IsBuilded = false;
            Symbol = (char)20;
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
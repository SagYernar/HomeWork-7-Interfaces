using System;

namespace ConsoleApp10
{
    public class Roof : IPart
    {
        public Roof()
        {
            IsBuilded = false;
            Symbol = (char)30;
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
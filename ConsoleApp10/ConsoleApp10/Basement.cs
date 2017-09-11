using System;

namespace ConsoleApp10
{
    public class Basement: IPart
    {

        public Basement()
        {
            IsBuilded = false;
            Symbol = '-';
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
using System;

namespace ConsoleApp10
{
    public class Window : IPart
    {
        public Window()
        {
            IsBuilded = false;
            Symbol = (char)15;
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
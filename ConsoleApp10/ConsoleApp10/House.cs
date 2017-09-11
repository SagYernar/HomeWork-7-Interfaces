using System;

namespace ConsoleApp10
{
    public class House
    {

        private const int wallsAndWindowsCounter = 4;
        public int WallsAndWindowsCounter
        {
            get
            {
                return wallsAndWindowsCounter;
            }
        }

        private IPart basement = new Basement();
        private IPart[] windows = new Window[wallsAndWindowsCounter];
        private IPart door = new Door();
        private IPart[] walls = new Wall[wallsAndWindowsCounter];
        private IPart roof;

        public IPart Basement
        {
            get
            {
                return basement;
            }
            set
            {
                basement = value;
            }
        }

        public IPart Door
        {
            get
            {
                return door;
            }
            set
            {
                door = value;
            }
        }

        public IPart Roof
        {
            get
            {
                return roof;
            }
            set
            {
                roof = value;
            }
        }

        public IPart Wall1
        {
            get
            {

                return walls[0];

            }
            set
            {
                walls[0] = value;
            }
        }

        public IPart Wall2
        {
            get
            {

                return walls[1];

            }
            set
            {
                walls[1] = value;
            }
        }

        public IPart Wall3
        {
            get
            {

                return walls[2];

            }
            set
            {
                walls[2] = value;
            }
        }

        public IPart Wall4
        {
            get
            {

                return walls[3];

            }
            set
            {
                walls[3] = value;
            }
        }

        public IPart this[int index]
        {
            get
            {
                return windows[index];
            }
            set
            {
                windows[index] = value;
            }
        }

        public House()
        {
            for (int i = 0; i < wallsAndWindowsCounter; ++i)
            {
                walls[i] = new Wall();
            }


            for (int i = 0; i < wallsAndWindowsCounter; ++i)
            {
                windows[i] = new Window();
            }
            roof = new Roof();
        }
    }
}
using System;

namespace ConsoleApp10
{
    public class Worker : IWorker
    {
        public void MakeWork(House house)
        {
            if (!house.Basement.IsBuilded)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 10; ++i)
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 10+1; ++i)
                {
                    Console.Write(house.Basement.Symbol);
                }
                Console.WriteLine();
                house.Basement.IsBuilded = true;
            }

            if (!house.Wall1.IsBuilded)
            {

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 10; ++i)
                {
                    Console.SetCursorPosition(0,i);
                    Console.Write(house.Wall1.Symbol);
                }

                house.Wall1.IsBuilded = true;
            }

            if (!house.Wall2.IsBuilded)
            {

                Console.SetCursorPosition(10, 0);
                for (int i = 0; i < 10; ++i)
                {
                    Console.SetCursorPosition(10, i);
                    Console.Write(house.Wall2.Symbol);
                }

                house.Wall2.IsBuilded = true;
            }

            if (!house.Wall3.IsBuilded)
            {               
                for (int i = 0; i < 10; ++i)
                {
                    Console.SetCursorPosition(i, 3);
                    Console.Write(house.Wall3.Symbol);
                }

                house.Wall3.IsBuilded = true;
            }

            if (!house.Wall4.IsBuilded)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(i, 6);
                    Console.Write(house.Wall4.Symbol);
                }

                house.Wall4.IsBuilded = true;
            }

            for (int j = 0; j < house.WallsAndWindowsCounter; j++)
            {
                if (!house[j].IsBuilded)
                {
                    for (int i = 0; i < 2; ++i)
                    {
                        if (j == 0)
                        {
                            Console.SetCursorPosition(2+i, 1);
                        }
                        else if (j == 1)
                        {
                            Console.SetCursorPosition(6+i, 1);
                        }
                        else if (j == 2)
                        {
                            Console.SetCursorPosition(2+i, 5);
                        }
                        else if (j == 3)
                        {
                            Console.SetCursorPosition(6+i, 5);
                        }
                        Console.Write(house[j].Symbol);
                    }

                    house[j].IsBuilded = true;
                }
            }

            if (!house.Roof.IsBuilded)
            {
                for (int i = 0; i < 10+1; ++i)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write(house.Roof.Symbol);
                }

                house.Roof.IsBuilded = true;
            }

            if (!house.Door.IsBuilded)
            {
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 0; j < 2; ++j)
                    {
                        Console.SetCursorPosition(j+4, 9-i);
                        Console.Write(house.Door.Symbol);
                    }
                }

                house.Door.IsBuilded = true;
            }
        }
    }
}
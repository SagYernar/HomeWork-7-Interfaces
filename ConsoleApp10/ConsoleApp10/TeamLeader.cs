using System;

namespace ConsoleApp10
{
    public class TeamLeader : IWorker
    {
        public int CountOfReports { get; set; }
        public TeamLeader()
        {
            CountOfReports = 0;
        }
        public void MakeWork(House house)
        {
            
            if (CountOfReports != 0)
            {
                Console.SetCursorPosition(0, 1 * CountOfReports + 22);
            }
            else
            {
                Console.SetCursorPosition(0, 1 * CountOfReports +11);
                CountOfReports = 1;
            }

            if (house.Basement.IsBuilded)
            {
                Console.WriteLine("Фундамент - заложен");
            }
            else
            {
                Console.WriteLine("Фундамент - не заложен");
            }
            
            if (house.Wall1.IsBuilded)
            {
                Console.WriteLine("Первая стена - построена");
            }
            else
            {
                Console.WriteLine("Первая стена - не построена");
            }
                        
            if (house.Wall2.IsBuilded)
            {
                Console.WriteLine("Вторая стена - построена");
            }
            else
            {
                Console.WriteLine("Вторая стена - не построена");
            }

            if (house.Wall3.IsBuilded)
            {
                Console.WriteLine("Третья стена - построена");
            }
            else
            {
                Console.WriteLine("Третья стена - не построена");
            }
            
            if (house.Wall4.IsBuilded)
            {
                Console.WriteLine("Четвертая стена - построена");
            }
            else
            {
                Console.WriteLine("Четвертая стена - не построена");
            }

            for (int i = 0; i < house.WallsAndWindowsCounter; ++i)
            {
                if (house[i].IsBuilded)
                {
                    Console.WriteLine("{0} окно - установлено", i);
                }
                else
                {
                    Console.WriteLine("{0} окно - не установлено", i);
                }
            }
            
            if (house.Door.IsBuilded)
            {
                Console.WriteLine("Дверь - установлена");
            }
            else
            {
                Console.WriteLine("Дверь - не установлена");
            }
            
            if (house.Roof.IsBuilded)
            {
                Console.WriteLine("Крыша - установлена");
            }
            else
            {
                Console.WriteLine("Крыша - не установлена");
            }
           
        }
    }
}
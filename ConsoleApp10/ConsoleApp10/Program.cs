using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод на экран всех символов текущей консоли
            //for(int i = 0; i < 250; i++)
            //{
            //    Console.WriteLine(i + " - " + (char)i);
            //}
            //Console.ReadLine();

            Team team = new Team();
            team.BuildingHouse();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.x = 1;
            point.y = 3;
            point.symbol = '*';

            point.Draw();

            Console.ReadLine();
        }
    }
}

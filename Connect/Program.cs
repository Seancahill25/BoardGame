using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class Program
    {
        private static bool IsXValid(int x)
        {
            return  x >= 30 || x < 1;
        }
        private static bool IsYValid(int y)
        {
            return y >= 30 || y < 1;
        }

        public static void DrawBoard(int x, int y)
        {
            var rows = 0;
            for (var i = 0; i < x; i++)
            {
                Console.Write(" |");
                if (i == x - 1)
                {
                    Console.WriteLine("");
                    if (rows == y)
                    {
                        break;
                    }
                    for (var j = 0; j < x; j++)
                    {
                        Console.Write("-+");
                        if (j == x - 1)
                        {
                            Console.WriteLine("-");
                        }
                    }
                    i = -1;
                    rows++;
                }
            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input width of board between 2 and 30");
            int x = Convert.ToInt32(Console.ReadLine()) - 1;
            while (IsXValid(x))
            {
                Console.WriteLine("\nInput width of board between 2 and 30");
                x = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            Console.WriteLine("\nInput height of board between 2 and 30");
            int y = Convert.ToInt32(Console.ReadLine()) - 1;
            while (IsYValid(y))
            {
                Console.WriteLine("\nInput height of board between 2 and 30");
                y = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            DrawBoard(x, y);
        }
    }
}

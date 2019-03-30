using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class Program
    {
        private static bool IsXValid(int XAxis)
        {
            return  XAxis >= 30 || XAxis < 1;
        }
        private static bool IsYValid(int YAxis)
        {
            return YAxis >= 30 || YAxis < 1;
        }

        public static void DrawBoard(int XAxis, int YAxis)
        {
            var rows = 0;
            for (var i = 0; i < XAxis; i++)
            {
                Console.Write(" |");
                if (i == XAxis - 1)
                {
                    Console.WriteLine("");
                    if (rows == YAxis)
                    {
                        break;
                    }
                    for (var j = 0; j < XAxis; j++)
                    {
                        Console.Write("-+");
                        if (j == XAxis - 1)
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

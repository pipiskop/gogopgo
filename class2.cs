using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Stepic
{
    class strelochki
    {
        public static int poz = 3;
        public static int MAX, MIN;

        public strelochki(int min, int max)
        {

            MAX = max;
            MIN = min;
        }
        public int strelochk()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                if (key.Key == ConsoleKey.UpArrow)
                {

                    poz--;

                    if (poz < MIN)
                    {
                        poz = MAX;
                    }
                    else if (poz > MAX + 1)
                    {
                        poz = MIN + 1;
                    }

                    for (int v = 99; v >= poz; v--)
                    {
                        Console.SetCursorPosition(0, v);
                        Console.WriteLine("  ");
                    }

                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("--");
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {

                    poz++;

                    if (poz <= MIN + 1)
                    {
                        poz = MAX;
                    }
                    else if (poz > MAX + 1)
                    {
                        poz = MIN;
                    }

                    for (int z = 0; z <= poz; z++)
                    {
                        Console.SetCursorPosition(0, z);
                        Console.WriteLine("  ");
                    }

                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("--");
                }

                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1111;
                }
                Console.SetCursorPosition(0, poz);
                Console.WriteLine("->");

            } while (key.Key == ConsoleKey.Enter);
            Console.Clear();
            return poz;
        }
    }
}
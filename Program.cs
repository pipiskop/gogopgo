using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stepic
{
    static class ex
    {
        public static int j = 0;
        public static void Final()
        {

            string A = Info();
            string B = Ways(A);
        }

        public static string Info()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("этот комп");
            Console.WriteLine("☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭☭");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Console.SetCursorPosition(0, 3);
            foreach (DriveInfo d in allDrives)
            {
                BigInteger a = d.TotalFreeSpace;
                a /= 1073741824;
                BigInteger b = d.TotalSize;
                b /= 1073741824;

                Console.WriteLine($"  {d.Name} {a} гигобайт свободно из твоих {b} гигов");
            }
            strelochki str = new strelochki(2, allDrives.Length + 1);
            int position = str.strelochk() - 2;
            return allDrives[position].Name;
        }

        static private string Ways(string name)
        {
            int file = 0;
            Console.WriteLine("доступны следующие папки: ");
            List<string> allData = new List<string>();
            var WayInfo = new DirectoryInfo(name);

            if (name.Contains("..."))
            {

                Process.Start(new ProcessStartInfo { FileName = name, UseShellExecute = true });
                return "";
            }

            string[] allDirectories = Directory.GetDirectories(name);
            string[] allFiles = Directory.GetFiles(name);
            allData.AddRange(allDirectories);
            allData.AddRange(allFiles);
            allData.Sort();

            foreach (string datas in allData)
            {
                Console.WriteLine($" {datas}");
                Console.SetCursorPosition(50, file + 2);
                Console.WriteLine($"{WayInfo.CreationTime} ");
                file++;
            }
            strelochki menu = new strelochki(2, file);
            int pos = menu.strelochk() - 2;

            if (pos == -1002)
            {
                Console.Clear();
                return "";
            }
            return Ways(allData[pos]);
        }
    }
}
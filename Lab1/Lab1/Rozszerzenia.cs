using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal static class Rozszerzenia
    {
        public static string GetAtrybuty(this FileSystemInfo fsi)
        {
            return fsi.Attributes.ToString();
        }

        public static int PoliczElementy(this DirectoryInfo katalog)
        {
            return katalog.GetFileSystemInfos().Length;
        }
    }
}
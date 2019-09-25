using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubReal.EasyDublicateFinder
{
    internal static class EdfFiles
    {
        public static List<FileDesc> FullListFiles { get; set; }

        /* private static List<FileDesc> fullListFiles;

        public static List<FileDesc> FullListFiles
        {
            get => fullListFiles;
            set => fullListFiles = value;
        }*/
       
    }

    internal class FileDesc
    {
        public string Name { get; set; }
        public long Size { get; set; }
  //      public int ControlSum { get; set; }
        public DateTime CreationTime { get; set; }
        public string MD5Summ { get; set; }
        public int CountDublicates { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OS2_Projekt
{
    static class FileManager
    {
        public static string RootPath;

        public static void WriteKeyToFile(string fileName, List<Tuple<string, byte[]>> keys)
        {
            string fullPath = RootPath + fileName;
            using (StreamWriter file = new StreamWriter(fullPath))
            {
                MyStringBuilder strBuilder = new MyStringBuilder();

                foreach (var key in keys)
                {
                    file.WriteLine(strBuilder.BuildKeyString(key));
                }
            }
        }       
    }
}

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
            StringKeyBuilder stringBuilder = new StringKeyBuilder();
            StreamWriter file = File.CreateText(RootPath + fileName);

            foreach(var key in keys)
            {
                file.WriteLine(stringBuilder.BuildString(key));
            }

            file.Close();

        }
    }
}

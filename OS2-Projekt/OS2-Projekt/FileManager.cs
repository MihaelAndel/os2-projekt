using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OS2_Projekt
{
    static class FileManager
    {
        public static string RootPath;

        public static void WriteKeyToFile(string fileName, List<Tuple<string, byte[]>> keys)
        {
            string fullPath = CreateFile(fileName);
            using (StreamWriter file = new StreamWriter(fullPath))
            {
                MyStringBuilder strBuilder = new MyStringBuilder();

                foreach (var key in keys)
                {
                    file.WriteLine(strBuilder.BuildKeyString(key));
                }
            }
        }

        public static void WriteTextToFile(string fileName, string text)
        {
            string fullPath = CreateFile(fileName);

            using (StreamWriter file = new StreamWriter(fullPath))
            {
                file.WriteLine(text);
            }
        }

        private static string CreateFile(string fileName)
        {
            string fullPath = RootPath + fileName;

            return fullPath;
        }

        public static string OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    return openFileDialog.FileName;
                } else return "";
            }
        }

        public static string ReadTextFile(string fullPath)
        {
            return File.ReadAllText(fullPath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS2_Projekt
{
    class MyStringBuilder
    {
        public string BuildKeyString(Tuple<string, byte[]> key)
        {
            string keyValue = Convert.ToBase64String(key.Item2);
            string label = key.Item1;

            //TODO komentar

            return label + ": " + keyValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS2_Projekt
{
    class StringKeyBuilder
    {
        public string BuildString(Tuple<string, byte[]> key)
        {
            string keyValue = Convert.ToBase64String(key.Item2);
            string label = key.Item1;

            return label + ": " + keyValue;
        }
    }
}

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
            int keyNumValue = BitConverter.ToInt32(key.Item2, 0);
            string keyTextValue = keyNumValue.ToString();
            string label = key.Item1;

            return label + ": " + keyTextValue;
        }
    }
}

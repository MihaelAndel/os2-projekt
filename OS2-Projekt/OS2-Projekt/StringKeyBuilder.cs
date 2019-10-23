using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS2_Projekt
{
    class StringKeyBuilder
    {
        public string BuildString(string text, byte[] key)
        {
            int keyNumValue = BitConverter.ToInt32(key, 0);
            string keyTextValue = keyNumValue.ToString();

            return text + ": " + keyTextValue;
        }
    }
}

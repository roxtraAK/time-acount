using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zeitkonto
{
    public static class Helper
    {
        public static string SimpleEncrypt(string input)
        {
            // "abc" --> "bcd" --> "abc" 
            // "abc" --> "lköasdfl" --> ???
            using (MD5 md5 = MD5.Create())
            {
                var _hashedString = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return System.Convert.ToBase64String(_hashedString);
            }
        }
    }
}

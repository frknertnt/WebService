using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceConsoleApp
{
    public static class SHA
    {
        public static string SHA256Create(string key)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytearray = Encoding.UTF8.GetBytes(key);
            byte[] hasharray = sha256.ComputeHash(bytearray);
            string hashstring = EditFormat(hasharray);

            return hashstring;
        }
        private static string EditFormat(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace SalesSystem.Helpers
{
    public class Cryptography
    {
       public static string GetMd5Hash( string input)
        {
            MD5 mD5hash = MD5.Create();
            byte[] data = mD5hash.ComputeHash(Encoding.UTF8.GetBytes(input));


            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash( string input, string hash)
        {
          
            string hashOfInput = GetMd5Hash(input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ProductSearchEngine.Business.Encryption
{
    public static class SHA1Encryption
    {
        public static string EncryptMessage(string message)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
           
             return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(message)));
        }

     
    }
}

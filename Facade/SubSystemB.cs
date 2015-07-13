using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Facade
{
    public class SubSystemB
    {
        public string Encrypt(string plaintext)
        {
                var md5=new MD5CryptoServiceProvider();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(plaintext);
                return plaintext;
        }
    }
}

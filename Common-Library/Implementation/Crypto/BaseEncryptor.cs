using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Crypto
{
    public abstract class BaseEncryptor
    {
        public static byte[] Encrypt(string str)
        {
            return null;
        }
        public static byte[] Encrypt(byte[] data)
        {
            return null;
        }
        public static bool IsHashOfString(byte[] hash, string sample)
        {
            return false;
        }
    }
}
